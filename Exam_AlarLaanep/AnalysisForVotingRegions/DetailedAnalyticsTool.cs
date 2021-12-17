using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnalysisForVotingRegions
{
    public class DetailedAnalyticsTool
    {
        public Dictionary<string, Dictionary<string, string>> _tallinnRegion2Results = new Dictionary<string, Dictionary<string, string>>();
        public DetailedAnalyticsTool()
        {
            _tallinnRegion2Results=ReadFile("Tallinn_region2_results.csv");
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
            foreach (KeyValuePair<string, Dictionary<string, string>> candidate in _tallinnRegion2Results)
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

            foreach (KeyValuePair<string, Dictionary<string, string>> candidate in _tallinnRegion2Results)
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
            foreach (KeyValuePair<string, Dictionary<string, string>> candidate in _tallinnRegion2Results)
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

        public string FindCandidatesWithPersonalMandate()
        {
            string result = string.Empty;
            int simpleQuota = GetSimpleQuota();
            foreach (KeyValuePair<string, Dictionary<string, string>> candidate in _tallinnRegion2Results)
            {
                string foundParty = FindTotalVotes("", candidate)[0];
                int totalVotes = int.Parse(FindTotalVotes("", candidate)[1]);
                if (totalVotes > simpleQuota)
                {
                    result += $"{candidate.Key} {foundParty} {totalVotes}";
                }
            }
            return result;

        }

        public Dictionary<string, Dictionary<string, string>> ReadFile(string fileName)
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
                        
                        string[] values = line.Split(",");
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

        public int GetSimpleQuota()
        {
            string lastLine = File.ReadLines("Tallinn_region2_results.csv").Last();
            lastLine = lastLine.Replace(",", "");

            
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
