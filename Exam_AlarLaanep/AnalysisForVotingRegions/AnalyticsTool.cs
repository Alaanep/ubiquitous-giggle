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

        //todo write unit tests
        public string FindMinimalNumberCouncilMembersForEachRuralMunicipality()
        {
            string result = string.Empty;
            foreach (KeyValuePair<string, Dictionary<string, int>> municipality in _generalData2021)
            {
                result += $"{municipality.Key}-> vähemalt {GetMinimalNumberCouncilMembers(municipality.Value["Regiooni rahvaarv"])} liiget.\n";
            }
            return result;
        }

        //todo write unit tests
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

        //todo refactor a lot of code dublication
        //todo write unit tests
        public string FindMunicipalityWithLowestAndHigestEVotePercentage()
        {
            string result = string.Empty;

            double mostEVotes = 0;
            string municipalityWithMostEVotes = string.Empty;

            double leastEVotes = 100;
            string municipalityWithLeastEVotes = string.Empty;

            foreach (KeyValuePair<string, Dictionary<string, int>> municipality in _generalData2021)
            {
                //Console.Write($"{municipality.Key} Paberil: {municipality.Value["Paberil häälte arv"]} E-Haaled: {municipality.Value["E-häälte arv"]}");
                int totalVotes = municipality.Value["Paberil häälte arv"] + municipality.Value["E-häälte arv"];
                double perctangeOfEVotes = ((double)municipality.Value["E-häälte arv"] / (double)totalVotes) * 100;
                //Console.WriteLine($" Perctantage of E-votes: {string.Format("{0:0.0}", perctangeOfEVotes)}%");
                if (perctangeOfEVotes > mostEVotes)
                {
                    mostEVotes = perctangeOfEVotes;
                    municipalityWithMostEVotes = municipality.Key;
                }

                if (perctangeOfEVotes < leastEVotes)
                {
                    leastEVotes = perctangeOfEVotes;
                    municipalityWithLeastEVotes = municipality.Key;
                }
            }
            result += $"E-voting percantage was highest in {municipalityWithMostEVotes}. E-Votes perctange was {string.Format("{0:0.0}", mostEVotes)}%\n";
            result += $"E-voting percantage was lowest in {municipalityWithLeastEVotes}. E-Votes perctange was {string.Format("{0:0.0}", leastEVotes)}%\n";
            //Console.WriteLine(result);
            return result;
        }

        //todo refactor a lot of code dublication
        //todo write unit test
        public string FindMunicipalityWithLowestAndHigestPaperVotePercentage()
        {
            string result = string.Empty;

            double mostPaperVotes = 0;
            string municipalityWithMostPaperVotes = string.Empty;

            double leastPaperVotes = 100;
            string municipalityWithLeastPaperVotes = string.Empty;

            foreach (KeyValuePair<string, Dictionary<string, int>> municipality in _generalData2021)
            {
                //Console.Write($"{municipality.Key} Paberil: {municipality.Value["Paberil häälte arv"]} E-Haaled: {municipality.Value["E-häälte arv"]}");
                int totalVotes = municipality.Value["Paberil häälte arv"] + municipality.Value["E-häälte arv"];
                double perctangeOfPaperVotes = ((double)municipality.Value["Paberil häälte arv"] / (double)totalVotes) * 100;
                //Console.WriteLine($" Perctantage of E-votes: {string.Format("{0:0.0}", perctangeOfEVotes)}%");
                if (perctangeOfPaperVotes > mostPaperVotes)
                {
                    mostPaperVotes = perctangeOfPaperVotes;
                    municipalityWithMostPaperVotes = municipality.Key;
                }

                if (perctangeOfPaperVotes < leastPaperVotes)
                {
                    leastPaperVotes = perctangeOfPaperVotes;
                    municipalityWithLeastPaperVotes = municipality.Key;
                }
            }
            result += $"Paper voting percantage was highest in {municipalityWithMostPaperVotes}. E-Votes perctange was {string.Format("{0:0.0}", mostPaperVotes)}%\n";
            result += $"Paper voting percantage was lowest in {municipalityWithLeastPaperVotes}. E-Votes perctange was {string.Format("{0:0.0}", leastPaperVotes)}%\n";
            //Console.WriteLine(result);
            return result;
            
        }

        //todo refactor because code dublication
        //write unit tests
        public string FindRegionWithHighestAndLowestVotingActivity()
        {
            string result = string.Empty;

            double highestVotingActivity = 0;
            string municipalityWithHighestVotingActivity = string.Empty;

            double lowestVotingActivity = 100;
            string municipalityWithlowestVotingActivity = string.Empty;

            foreach (KeyValuePair<string, Dictionary<string, int>> municipality in _generalData2021)
            {
                int totalVotes = municipality.Value["Paberil häälte arv"] + municipality.Value["E-häälte arv"];
                double votingActivity = ((double)totalVotes/ (double)municipality.Value["Hääleõiguslikke kodanikke"]) * 100;
                //Console.Write($"{municipality.Key}: Hääleõiguslikke kodanikke: {municipality.Value["Hääleõiguslikke kodanikke"] } häälte arv: {totalVotes}");
                //Console.WriteLine($" Voting Activity: {string.Format("{0:0.0}", votingActivity)}%");

                if (votingActivity > highestVotingActivity)
                {
                    highestVotingActivity = votingActivity;
                    municipalityWithHighestVotingActivity = municipality.Key;
                }

                if (votingActivity < lowestVotingActivity)
                {
                    lowestVotingActivity = votingActivity;
                    municipalityWithlowestVotingActivity = municipality.Key;
                }
            }
            result += $"Highest voting activity was in {municipalityWithHighestVotingActivity}. Voting perctange was {string.Format("{0:0.0}", highestVotingActivity)}%\n";
            result += $"Lowest voting activity  was in {municipalityWithlowestVotingActivity}. Voting perctange was {string.Format("{0:0.0}", lowestVotingActivity)}%\n";
            //Console.WriteLine(result);
            return result;
        }

        public void PrintVotingActitityAndPercentageOfVotes(string region)
        {
            if (_generalData2021.ContainsKey(region))
            {
                //percentage of e-votes
                int totalVotes = _generalData2021[region]["Paberil häälte arv"] + _generalData2021[region]["E-häälte arv"];
                double perctangeOfEVotes = ((double)_generalData2021[region]["E-häälte arv"] / (double)totalVotes) * 100;

                //perctange of paper votes
                double perctangeOfPaperVotes = ((double)_generalData2021[region]["Paberil häälte arv"] / (double)totalVotes) * 100;

                //voting activity
                double votingActivity = ((double)totalVotes / (double)_generalData2021[region]["Hääleõiguslikke kodanikke"]) * 100;

                Console.WriteLine($"{region}-> Valimisaktiivsus on {string.Format("{0:0.0}", votingActivity)}%, e-häälte osakaal on {string.Format("{0:0.0}", perctangeOfEVotes)}% ning paberhäälte osakaal {string.Format("{0:0.0}", perctangeOfPaperVotes)}%  ");
            }
            else
            {
                Console.WriteLine($"Could not found info based on {region}");
            }
        }

        public void PrintInfoForAllRegions()
        {
            //total voting activity
            int totalVotesForAllRegions = 0;
            int totalVotersForAllRegions = 0;
            double totalVotingActivity = 0;

            Dictionary<string, double> regionsVotingActivity = new Dictionary<string, double>();

            foreach (KeyValuePair<string, Dictionary<string, int>> municipality in _generalData2021)
            {
                
                int totalVotes = municipality.Value["Paberil häälte arv"] + municipality.Value["E-häälte arv"];

                double votingActivity = ((double)totalVotes / (double)municipality.Value["Hääleõiguslikke kodanikke"]) * 100;

                regionsVotingActivity.TryAdd(municipality.Key, votingActivity);
                totalVotesForAllRegions += totalVotes;
                totalVotersForAllRegions += municipality.Value["Hääleõiguslikke kodanikke"];
                
                //Console.Write($"{municipality.Key}: Hääleõiguslikke kodanikke: {municipality.Value["Hääleõiguslikke kodanikke"] } häälte arv: {totalVotes}");
                //Console.WriteLine($" Voting Activity: {string.Format("{0:0.0}", votingActivity)}%");
            }
            totalVotingActivity = ((double)totalVotesForAllRegions / (double)totalVotersForAllRegions) * 100;
            Console.WriteLine($"Total voting activity for all regions: {string.Format("{0:0.0}", totalVotingActivity)}%");
            Console.WriteLine();

            foreach (KeyValuePair<string, double> item in regionsVotingActivity.OrderByDescending(key => key.Value))
            {
                Console.WriteLine($"{item.Key} {string.Format("{0:0.0}", item.Value)}%");
            }
            Console.WriteLine();

            Console.WriteLine($"Total voters for all regions: {totalVotesForAllRegions}");
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
                //Console.Write($"{municipality.Key}: Hääleõiguslikke kodanikke: {municipality.Value["Hääleõiguslikke kodanikke"] } häälte arv: {totalVotes}");
                //Console.WriteLine($" Voting Activity: {string.Format("{0:0.0}", votingActivity)}%");

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
            result += $"Highest perctange of citizens with right to vote was in {municipalityWithHighestPercentage}. with {string.Format("{0:0.0}", highestPercentage)}% of citizen right to vote\n";
            result += $"Lowest perctange of citizens with right to vote was in {municipalityWithlowestPercentage}. with {string.Format("{0:0.0}", lowestPercentage)}% of citizen right to vote\n";
            //Console.WriteLine(result);
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
                            result += $"Next elections {kovElectionYears[i]} ";
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

        public void CreateAccountNameAndSave(string inputName)
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
                Console.WriteLine("Please enter firstname and lastname");
            } else if (names.Length == 2)
            {
                for (int i = 0; i < names.Length; i++) {

                    if (names[i].Length >= 6)
                    {
                        accountname += names[i].Substring(0, 6);
                    } else
                    {
                        accountname += names[i].Substring(0, names[i].Length);
                    }
                    if (i == 0)
                    {
                        accountname += ".";
                    }
                }
            } else if (names.Length >= 3)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (i == 0 || i == 1 )
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
                    if(i== names.Length - 1)
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
            Console.WriteLine(accountname);
            
        }

        //todo refactor ReadFromFile method?
        //todo write unit Tests for ReadFromFile
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
