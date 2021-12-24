using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnalysisForVotingRegions
{
    public class DetailedAnalyticsTool: AnalyticsTool
    {
        public Dictionary<string, Dictionary<string, string>> _regionResults = new Dictionary<string, Dictionary<string, string>>();
        private string _splitter;
        private string _filename;
        public DetailedAnalyticsTool(string fileName, string splitter)
        {
            _filename = fileName;
            _regionResults = ReadFile(fileName, splitter);
            _splitter = splitter;
        }

        public List<string> FindTotalVotes(string partyName, KeyValuePair<string, Dictionary<string, string>> candidate)
        {
            string foundPartyName = string.Empty;
            StringComparison comp = StringComparison.OrdinalIgnoreCase;
            if (candidate.Value["Erakonna nimi / Party name"].Contains(partyName, comp))
            {
                foundPartyName = candidate.Value["Erakonna nimi / Party name"];
                int paperVotes = 0;
                int eVotes = 0;
                try
                {
                    paperVotes = int.Parse(candidate.Value["Paberhääled / Paper votes"]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    paperVotes = 0;
                }
                try
                {
                    eVotes = int.Parse(candidate.Value["E-hääled / E-votes"]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    eVotes = 0;
                }
                return new List<string> { foundPartyName, (paperVotes + eVotes).ToString() };
            }
            return null;
        }

        public string FindTotalNumberOfVotesForParty(string partyName)
        {
            int totalVotes = 0;
            string foundPartyName = string.Empty;
            foreach (KeyValuePair<string, Dictionary<string, string>> candidate in _regionResults)
            {   if(FindTotalVotes(partyName, candidate) != null)
                {
                    foundPartyName = FindTotalVotes(partyName, candidate)[0];
                    totalVotes += int.Parse(FindTotalVotes(partyName, candidate)[1]);
                }
            }
            if (totalVotes == 0)
            {
                return $"Could not found info based on {partyName}";
            } else
            {
                return $"{foundPartyName}-> {totalVotes}";
            }
        }

        public string FoundPersonWithLeastAndMostVotes(string partyName)
        {
            string result=string.Empty;
            int mostVotes = 0;
            string personWithMostVotes = string.Empty;

            int leastVotes = 1000000000;
            string personWithLeastVotes = string.Empty;

            string foundPartyName = string.Empty;

            foreach (KeyValuePair<string, Dictionary<string, string>> candidate in _regionResults)
            {
                int totalVotes = 0;
                if (FindTotalVotes(partyName, candidate) != null)
                {
                    foundPartyName = FindTotalVotes(partyName, candidate)[0];
                    totalVotes = int.Parse(FindTotalVotes(partyName, candidate)[1]);

                    if (totalVotes > mostVotes)
                    {
                        mostVotes = totalVotes;
                        personWithMostVotes = candidate.Key;
                    }

                    if (totalVotes < leastVotes)
                    {
                        leastVotes = totalVotes;
                        personWithLeastVotes = candidate.Key;
                    }
                }
            }
            if (foundPartyName == string.Empty)
            {
                return $"Could not found info based on {partyName}";
            } else
            {
                result = $"{foundPartyName}-> {personWithMostVotes} ({mostVotes}), {personWithLeastVotes} ({leastVotes})";
            }
            return result;
        }

        public string FindPersonsWithZeroVotes()
        {
            string result = string.Empty;
            foreach (KeyValuePair<string, Dictionary<string, string>> candidate in _regionResults)
            {
                int paperVotes = 0;
                int eVotes = 0;
                try
                {
                    paperVotes = int.Parse(candidate.Value["Paberhääled / Paper votes"]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    paperVotes = 0;
                }
                try
                {
                    eVotes = int.Parse(candidate.Value["E-hääled / E-votes"]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    eVotes = 0;
                }

                if (paperVotes == 0 || eVotes == 0)
                {
                    result += candidate.Key+"\n";
                }

            }
            if (result == string.Empty)
            {
                result = "No people with zero votes";
            }
            return result;
        }

        public List<string> CreateListFromAccountNames()
        {
            List<string> accountNames = new List<string>();

            using(StreamReader reader = new StreamReader("accountNames.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    accountNames.Add(line);
                }
            }
            return accountNames;
        }

        public override string CreateAccountNameAndSave(string inputName)
        {
            List<string> accountNames = CreateListFromAccountNames();
            string accountName = CreateAccountName(inputName);

            if (accountName == null)
            {
                return "For account name please enter firstname and lastname";
            }
            int count = 0;
            while (accountNames.Contains(accountName))
            {
                if (accountName.Length >= 13)
                {
                    string accountNameLastChar;
                    if (count < 10)
                    {
                        accountNameLastChar = accountName.Substring(accountName.Length - 1);
                    }
                    else
                    {
                        accountNameLastChar = accountName.Substring(accountName.Length - 2);
                    }


                    if (int.TryParse(accountNameLastChar, out count))
                    {
                        count++;
                        accountName = accountName.Substring(0, accountName.Length - accountNameLastChar.Length) + count;

                    }
                    else
                    {
                        count++;
                        accountName = accountName.Substring(0, accountName.Length - accountNameLastChar.Length) + count.ToString(); ;
                    }
                } else
                {
                    count++;
                    accountName = accountName + count.ToString(); ;
                }
                
            }
            SaveAccountNameToFile(accountName);
            return accountName;
        }

        public void CreateAccountNameAndSaveForEveryCandidate()
        {
            foreach (KeyValuePair<string, Dictionary<string, string>> candidate in _regionResults)
            {
                CreateAccountNameAndSave(candidate.Key);
            }
        }

        public string FindCandidatesWithPersonalMandate()
        {
            string result = string.Empty;
            int simpleQuota = GetSimpleQuota(_splitter);
            foreach (KeyValuePair<string, Dictionary<string, string>> candidate in _regionResults)
            {
                string foundParty = FindTotalVotes("", candidate)[0];
                int totalVotes = int.Parse(FindTotalVotes("", candidate)[1]);
                if (totalVotes > simpleQuota)
                {
                    result += $"{candidate.Key} {foundParty} {totalVotes}\n";
                }
            }
            if (result == string.Empty)
            {
                return "There wasn't not any candidates who got personal mandate";
            }
            return result;

        }

        public Dictionary<string, Dictionary<string, string>> ReadFile(string fileName, string splitter)
        {
            Dictionary<string, Dictionary<string, string>> dataFromFile = new Dictionary<string, Dictionary<string, string>>();
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    List<string> partyName = new List<string>();
                    List<string> personName = new List<string>();
                    List<string> eVotes = new List<string>();
                    List<string> paperVotes = new List<string>();
                    string line;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        
                        string[] values = line.Split(splitter);
                        try
                        {
                            partyName.Add(values[0]);
                            personName.Add(values[1]);
                            eVotes.Add(values[2]);
                            paperVotes.Add(values[3]);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    for (int i = 1; i < partyName.Count-1; i++)
                    {
                        Dictionary<string, string> dic = new Dictionary<string, string>();
                        dic.TryAdd(partyName[0], partyName[i]);
                        dic.TryAdd(eVotes[0], eVotes[i]);
                        dic.TryAdd(paperVotes[0], paperVotes[i]);
                        dataFromFile.TryAdd(personName[i], dic);
                    }
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataFromFile;
        }

        public int GetSimpleQuota(string splitter)
        {
            string lastLine = File.ReadLines(_filename).Last();
            lastLine = lastLine.Replace(splitter, "");

            
            if(int.TryParse(lastLine, out int quota))
            {
                return quota;
            }
            else
            {
                return 0;
            }
        }

    }
}
