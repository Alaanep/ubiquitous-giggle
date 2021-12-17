using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnalysisForVotingRegions
{
    public class AnalyticsTool
    {
        public Dictionary<string, Dictionary<string, int>> _generalData2021 = new Dictionary<string, Dictionary<string, int>>();
        public Dictionary<string, Dictionary<string, int>> _statistics = new Dictionary<string, Dictionary<string, int>>();

        public AnalyticsTool()
        {
            _generalData2021 = ReadFromFile("GeneralData2021.txt", ",");
            _statistics = ReadFromFile("statistika.txt", ";");
        }

        public string FindMinimalNumberCouncilMembersForEachRuralMunicipality()
        {
            string result = string.Empty;
            foreach (KeyValuePair<string, Dictionary<string, int>> municipality in _generalData2021)
            {
                result += $"{municipality.Key}-> vähemalt {GetMinimalNumberCouncilMembers(municipality.Value["Regiooni rahvaarv"])} liiget.\n";
            }
            return result;
        }

        public int GetMinimalNumberCouncilMembers(int population)
        {
            if (population > 300000)
            {
                return 79;
            }
            else if (population > 50000)
            {
                return 31;
            }
            else if (population > 30000)
            {
                return 25;
            }
            else if (population > 10000)
            {
                return 21;
            }
            else if (population > 7500)
            {
                return 19;
            }
            else if (population > 5000)
            {
                return 17;
            }
            else if (population > 3500)
            {
                return 15;
            }
            else if (population > 2000)
            {
                return 13;
            }
            else
            {
                return 7;
            }
        }

        public double FindHighestPercentage(string key, string paperVotes, string eVotes, bool reverse = true)
        {
            double highestPercentage = 0;
            
            foreach (KeyValuePair<string, Dictionary<string, int>> municipality in _generalData2021)
            {
                int totalVotes = municipality.Value[paperVotes] + municipality.Value[eVotes];
                double percetangeOf = 0;
                if (reverse)
                {
                    percetangeOf = ((double)municipality.Value[key] / (double)totalVotes) * 100;
                }
                else
                {
                    percetangeOf = ((double)totalVotes/ (double)municipality.Value[key]) * 100;
                }
                
                if (percetangeOf > highestPercentage)
                {
                    highestPercentage = percetangeOf;
                }
            }
            return highestPercentage;
        }

        public string FindMunicipalityWithHighestPercentage(string key, string paperVotes, string eVotes, bool reverse=true)
        {
            double highestPercentage = 0;
            string municipalityWithHighestPercentage = string.Empty;

            foreach (KeyValuePair<string, Dictionary<string, int>> municipality in _generalData2021)
            {
                
                int totalVotes = municipality.Value[paperVotes] + municipality.Value[eVotes];
                double percetangeOf = 0;
                if (reverse)
                {
                    percetangeOf = ((double)municipality.Value[key] / (double)totalVotes) * 100;
                }
                else
                {
                    percetangeOf = ((double)totalVotes / (double)municipality.Value[key]) * 100;
                }
               
                if (percetangeOf > highestPercentage)
                {
                    highestPercentage = percetangeOf;
                    municipalityWithHighestPercentage = municipality.Key;
                }
            }
            return municipalityWithHighestPercentage;
        }

        public double FindLowestPercentage(string key, string paperVotes, string eVotes, bool reverse=true)
        {
            double lowestPercentage = 100;

            foreach (KeyValuePair<string, Dictionary<string, int>> municipality in _generalData2021)
            {
                int totalVotes = municipality.Value[paperVotes] + municipality.Value[eVotes];
                double percetangeOf = 0;
                if (reverse)
                {
                    percetangeOf = ((double)municipality.Value[key] / (double)totalVotes) * 100;
                }
                else
                {
                    percetangeOf = ((double)totalVotes / (double)municipality.Value[key]) * 100;
                }
                if (percetangeOf < lowestPercentage)
                {
                    lowestPercentage = percetangeOf;
                }
            }
            return lowestPercentage;
        }

        public string FindMunicipalityWithLowestPercentage(string key, string paperVotes, string eVotes, bool reverse=true)
        {
            double lowestPercentage = 100;
            string municipalityWithLowestPercentage = string.Empty;

            foreach (KeyValuePair<string, Dictionary<string, int>> municipality in _generalData2021)
            {
                int totalVotes = municipality.Value[paperVotes] + municipality.Value[eVotes];
                double percetangeOf = 0;
                if (reverse)
                {
                    percetangeOf = ((double)municipality.Value[key] / (double)totalVotes) * 100;
                }
                else
                {
                    percetangeOf = ((double)totalVotes / (double)municipality.Value[key]) * 100;
                }
                if (percetangeOf < lowestPercentage)
                {
                    lowestPercentage = percetangeOf;
                    municipalityWithLowestPercentage = municipality.Key;
                }
            }
            return municipalityWithLowestPercentage;
        }

        public string FindMunicipalityWithLowestAndHigestEVotePercentage()
        {
            double mostEVotes = FindHighestPercentage("E-häälte arv", "Paberil häälte arv", "E-häälte arv");
            string municipalityWithMostEVotes = FindMunicipalityWithHighestPercentage("E-häälte arv", "Paberil häälte arv", "E-häälte arv");

            double leastEVotes = FindLowestPercentage("E-häälte arv", "Paberil häälte arv", "E-häälte arv");
            string municipalityWithLeastEVotes = FindMunicipalityWithLowestPercentage("E-häälte arv", "Paberil häälte arv", "E-häälte arv");

            string result = $"E-voting percantage was highest in {municipalityWithMostEVotes}. E-Votes perctange was {string.Format("{0:0.0}", mostEVotes)}%\n";
            result += $"E-voting percantage was lowest in {municipalityWithLeastEVotes}. E-Votes perctange was {string.Format("{0:0.0}", leastEVotes)}%\n";
            return result;
        }

        public string FindMunicipalityWithLowestAndHigestPaperVotePercentage()
        {
            double mostPaperVotes = FindHighestPercentage("Paberil häälte arv", "Paberil häälte arv", "E-häälte arv");
            string municipalityWithMostPaperVotes = FindMunicipalityWithHighestPercentage("Paberil häälte arv", "Paberil häälte arv", "E-häälte arv");

            double leastPaperVotes = FindLowestPercentage("Paberil häälte arv", "Paberil häälte arv", "E-häälte arv");
            string municipalityWithLeastPaperVotes = FindMunicipalityWithLowestPercentage("Paberil häälte arv", "Paberil häälte arv", "E-häälte arv");

            string result = $"Paper voting percantage was highest in {municipalityWithMostPaperVotes}. Paper Votes perctange was {string.Format("{0:0.0}", mostPaperVotes)}%\n";
            result += $"Paper voting percantage was lowest in {municipalityWithLeastPaperVotes}. Paper Votes perctange was {string.Format("{0:0.0}", leastPaperVotes)}%\n";
            return result;
            
        }

        public string FindRegionWithHighestAndLowestVotingActivity()
        {
            string result = string.Empty;

            double highestVotingActivity = FindHighestPercentage("Hääleõiguslikke kodanikke", "Paberil häälte arv", "E-häälte arv", false) ;
            string municipalityWithHighestVotingActivity = FindMunicipalityWithHighestPercentage("Hääleõiguslikke kodanikke", "Paberil häälte arv", "E-häälte arv", false);

            double lowestVotingActivity = FindLowestPercentage("Hääleõiguslikke kodanikke", "Paberil häälte arv", "E-häälte arv", false);
            string municipalityWithlowestVotingActivity = FindMunicipalityWithLowestPercentage("Hääleõiguslikke kodanikke", "Paberil häälte arv", "E-häälte arv", false);
            result += $"Highest voting activity was in {municipalityWithHighestVotingActivity}. Voting perctange was {string.Format("{0:0.0}", highestVotingActivity)}%\n";
            result += $"Lowest voting activity  was in {municipalityWithlowestVotingActivity}. Voting perctange was {string.Format("{0:0.0}", lowestVotingActivity)}%\n";
            return result;
        }

        public string GetVotingActitityAndPercentageOfVotes(string region)
        {
            foreach (KeyValuePair<string, Dictionary<string, int>> municipality in _generalData2021)
            {
                StringComparison comp = StringComparison.OrdinalIgnoreCase;
                if(municipality.Key.Contains(region, comp)){
                    region = municipality.Key;
                    
                    int totalVotes = _generalData2021[region]["Paberil häälte arv"] + _generalData2021[region]["E-häälte arv"];
                    double perctangeOfEVotes = ((double)_generalData2021[region]["E-häälte arv"] / (double)totalVotes) * 100;

                    double perctangeOfPaperVotes = ((double)_generalData2021[region]["Paberil häälte arv"] / (double)totalVotes) * 100;

                    double votingActivity = ((double)totalVotes / (double)_generalData2021[region]["Hääleõiguslikke kodanikke"]) * 100;

                    return $"{region}-> Valimisaktiivsus on {string.Format("{0:0.0}", votingActivity)}%, e-häälte osakaal on {string.Format("{0:0.0}", perctangeOfEVotes)}% ning paberhäälte osakaal {string.Format("{0:0.0}", perctangeOfPaperVotes)}%";
                }
            }
            return $"Could not found info based on {region}";   
        }

        //todo how to unit test?
        public string PrintInfoForAllRegions()
        {
            int totalVotesForAllRegions = 0;
            int totalVotersForAllRegions = 0;
            double totalVotingActivity = 0;
            string result = string.Empty;

            Dictionary<string, double> regionsVotingActivity = new Dictionary<string, double>();

            foreach (KeyValuePair<string, Dictionary<string, int>> municipality in _generalData2021)
            {
                
                int totalVotes = municipality.Value["Paberil häälte arv"] + municipality.Value["E-häälte arv"];

                double votingActivity = ((double)totalVotes / (double)municipality.Value["Hääleõiguslikke kodanikke"]) * 100;

                regionsVotingActivity.TryAdd(municipality.Key, votingActivity);
                totalVotesForAllRegions += totalVotes;
                totalVotersForAllRegions += municipality.Value["Hääleõiguslikke kodanikke"];
                
            }
            totalVotingActivity = ((double)totalVotesForAllRegions / (double)totalVotersForAllRegions) * 100;
            result+=$"Total voting activity for all regions: {string.Format("{0:0.0}", totalVotingActivity)}%\n\n";
            

            foreach (KeyValuePair<string, double> item in regionsVotingActivity.OrderByDescending(key => key.Value))
            {
                result+=$"{item.Key} {string.Format("{0:0.0}", item.Value)}%\n";
            }
            result += "\n";

            result+=$"Total voters for all regions: {totalVotesForAllRegions}\n";
            return result;
        }

        public string FindRegionWithHighestAndLowestPercentageOfCitizensWithTheRightToVote()
        {
            string result = string.Empty;

            double highestPercentage = 0;
            string municipalityWithHighestPercentage = string.Empty;

            double lowestPercentage = 100;
            string municipalityWithlowestPercentage = string.Empty;

            foreach (KeyValuePair<string, Dictionary<string, int>> municipality in _generalData2021)
            {
                double percentageOfCitizensWithTheRightToVote = ((double)municipality.Value["Hääleõiguslikke kodanikke"] / (double)municipality.Value["Regiooni rahvaarv"]) * 100;

                if (percentageOfCitizensWithTheRightToVote> highestPercentage)
                {
                    highestPercentage = percentageOfCitizensWithTheRightToVote;
                    municipalityWithHighestPercentage = municipality.Key;
                }

                if (percentageOfCitizensWithTheRightToVote< lowestPercentage)
                {
                    lowestPercentage = percentageOfCitizensWithTheRightToVote;
                    municipalityWithlowestPercentage = municipality.Key;
                }
            }
            result += $"Highest perctange of citizens with right to vote was in {municipalityWithHighestPercentage} with {string.Format("{0:0.0}", highestPercentage)}% of citizen right to vote\n";
            result += $"Lowest perctange of citizens with right to vote was in {municipalityWithlowestPercentage} with {string.Format("{0:0.0}", lowestPercentage)}% of citizen right to vote\n";
            return result;
        }

        public string FindIfElectionsAreHeld(int year)
        {
            string result = string.Empty;
            List<int> kovElectionYears = new List<int> {1921, 1924, 1927, 1930, 1934, 1939, 1993, 1996, 1999, 2002, 2005, 2009, 2013, 2017, 2021};  
            if (kovElectionYears.Contains(year))
            {
                return $"Elections are being held in {year}";
            } else
            {
                result = $"No elections on {year}. ";
                if (year > kovElectionYears[kovElectionYears.Count - 1])
                {
                    result += $"Previous elections {kovElectionYears[kovElectionYears.Count - 1]}. ";
                    result += $"Next elections should be held in {kovElectionYears[kovElectionYears.Count - 1] + 4}";
                    return result;
                }
                else
                {
                    for (int i = 0; i < kovElectionYears.Count; i++)
                    {
                        if (year < kovElectionYears[i])
                        {
                            if (i - 1 >= 0)
                            {
                                result += $"Prevoius elections: {kovElectionYears[i - 1]}. ";
                            }
                            else
                            {
                                result += $"No previous elections. Elections were held first time in {kovElectionYears[i]}.";
                                return result;
                            }
                            result += $"Next elections {kovElectionYears[i]}";
                            return result;
                        }
                    }
                }
            }
            return result;
        }

        public string FindIfPersonCouldVoteOrStandAsCandidate(string personalCode)
        {
            string result=string.Empty;
            
            DateTime electionsDay = new DateTime(2021, 9, 12);
            int personAge = 0;


            if (PersonalCodeValidator.ValidateIdCode(personalCode))
            {
                result += $"{personalCode} -> ";
                DateTime birthDate = PersonalCodeValidator.GetBirthDate(personalCode);
                TimeSpan timeDifference = electionsDay - birthDate;
                personAge = (int)Math.Floor(timeDifference.Days / 365.25);

                if(personAge >= 16)
                {
                    result += "Hääletada saab";
                    if (personAge >= 18)
                    {
                        result += ", kandideerida saab.";
                    } else
                    {
                        result += ", kandideerida ei saa";
                    }
                } else
                {
                    result += "Hääletada ei saa, kandideerida ei saa.";
                }

            } else
            {
                return "Invalid personalcode";
            }
            return result;
        }

        public string CreateAccountName(string inputName)
        {
            string name = inputName.ToLower();

            string[] charsToReplace = new string[] { "ä", "ü", "õ", "ö" };
            string[] replaceWith = new string[] { "a", "u", "o", "o" };

            //replace ä,ö,ü,õ
            for (int i = 0; i < charsToReplace.Length; i++)
            {
                name = name.Replace(charsToReplace[i].ToString(), replaceWith[i].ToString());
            }


            string[] names = name.Split(" ");
            string accountname = string.Empty;

            if (names.Length == 1)
            {
                return null;
            }
            else if (names.Length == 2)
            {
                for (int i = 0; i < names.Length; i++)
                {

                    if (names[i].Length >= 6)
                    {
                        accountname += names[i].Substring(0, 6);
                    }
                    else
                    {
                        accountname += names[i].Substring(0, names[i].Length);
                    }
                    if (i == 0)
                    {
                        accountname += ".";
                    }
                }
            }
            else if (names.Length >= 3)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (i == 0 || i == 1)
                    {
                        if (names[i].Length >= 3)
                        {
                            accountname += names[i].Substring(0, 3);
                        }
                        else
                        {
                            accountname += names[i].Substring(0, names[i].Length);
                        }
                        if (i != names.Length - 1)
                        {
                            accountname += ".";
                        }
                    }
                    if (i == names.Length - 1)
                    {
                        if (names[i].Length >= 6)
                        {
                            accountname += names[i].Substring(0, 6);
                        }
                        else
                        {
                            accountname += names[i].Substring(0, names[i].Length);
                        }
                    }
                }
            }
            return accountname;
        }

        public void SaveAccountNameToFile(string accountName)
        {
            string fileName = "accountNames.txt";
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                try
                {
                    writer.WriteLine(accountName);
                    Console.WriteLine($"Account name: {accountName} was added to {fileName}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public virtual string CreateAccountNameAndSave(string inputName)
        {
            string accountName = CreateAccountName(inputName);
            if (accountName == null)
            {
                return "For account name please enter firstname and lastname";
            }
            SaveAccountNameToFile(accountName);
            return accountName;
        }

        public string FindBiggestWinnersAndLosers()
        {
            string result = string.Empty;
            string biggestWinner = string.Empty;
            double biggestWin = 0;
            string biggestLoser = string.Empty;
            double biggestLost = 100;


            foreach (KeyValuePair<string, Dictionary<string, int>> erakond in _statistics)
            {

                double electionResult = erakond.Value["Tegelik tulemus"] - erakond.Value["Ennustatav tulemus"];

                if (electionResult > biggestWin)
                {
                    biggestWin = electionResult;
                    biggestWinner = erakond.Key;
                }

                if (electionResult < biggestLost)
                {
                    biggestLost = electionResult;
                    biggestLoser = erakond.Key;
                }
            }
            result += $"Biggest winner was {biggestWinner} with {biggestWin} more places than expected.\n";
            result += $"Biggest loser was {biggestLoser} with {biggestLost*-1} places less than expected.\n";
            return result;
        }

        public Dictionary<string, Dictionary<string, int>> ReadFromFile(string fileName, string splitter)
        {
            Dictionary<string, Dictionary<string, int>> dataFromFile = new Dictionary<string, Dictionary<string, int>>();
            string[] keys = new string[5];
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line = "";
                    int j = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Dictionary<string, int> dic = new Dictionary<string, int>();
                        string[] data=new string[line.Split(splitter).Length];
                        //first line in file is column names. Use them as dictionary keys
                        if ( j== 0)
                        {   
                            keys = line.Split(splitter);
                        }
                        else //if not first line then must be values
                        {
                            data = line.Split(splitter);
                            for (int i = 1; i < keys.Length; i++)
                            {
                                try // try to populate dictionary with keyvalue pairs for textfile
                                {
                                    dic.TryAdd(keys[i], int.Parse(data[i].Replace(" ", "")));//remove whitespace from values, data might be corrupted
                                }
                                catch (Exception ex)
                                {
                                    Console.Write(ex.Message);
                                    Console.WriteLine($" Check datafile. Invalid data or dataformat in datafile\n{data[0]} {keys[i]} value defaulted to 0 ");
                                    dic.TryAdd(keys[i], 0);
                                }
                            }
                            dataFromFile.Add(data[0], dic);//use first value from line as dictionary key
                        }
                        j++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dataFromFile;
        }
    }
}
