using System;
using System.Collections.Generic;
namespace AnalysisForVotingRegions
{
    class Program
    {
        static void Main(string[] args)
        {
            AnalyticsTool analyticsTool = new AnalyticsTool();
            //Console.WriteLine(analyticsTool.FindMinimalNumberCouncilMembersForEachRuralMunicipality());
            //Console.WriteLine( analyticsTool.FindMunicipalityWithLowestAndHigestEVotePercentage());
            //Console.WriteLine( analyticsTool.FindMunicipalityWithLowestAndHigestPaperVotePercentage());
            //Console.WriteLine( analyticsTool.FindRegionWithHighestAndLowestVotingActivity());
            //analyticsTool.PrintVotingActitityAndPercentageOfVotes("Tartu linn");
            //analyticsTool.PrintInfoForAllRegions();

            //Console.WriteLine( analyticsTool.FindRegionWithHighestAndLowestPercentageOfCitizensWithTheRightToVote());
            //Console.WriteLine(analyticsTool.FindIfElectionsAreHeld(2050));

            //Console.WriteLine(analyticsTool.FindIfPersonCouldVoteOrStandAsCandidate("50409112269"));
            analyticsTool.CreateAccountNameAndSave("HöövelÜ Jäääääar");
            //foreach (KeyValuePair<string, Dictionary<string, int>> maakond in analyticsTool._generalData2021)
            //{
            //    Console.WriteLine($"Key: {maakond.Key}");
            //    foreach (KeyValuePair<string, int> data in maakond.Value)
            //    {
            //        Console.WriteLine($"Key: {data.Key}, Value: {data.Value}");
            //    }
            //    Console.WriteLine();
            //}

            //foreach (KeyValuePair<string, Dictionary<string, int>> erakond in analyticsTool._statistics)
            //{
            //    Console.WriteLine($"Key: {erakond.Key}");
            //    foreach (KeyValuePair<string, int> data in erakond.Value)
            //    {
            //        Console.WriteLine($"Key: {data.Key}, Value: {data.Value}");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
