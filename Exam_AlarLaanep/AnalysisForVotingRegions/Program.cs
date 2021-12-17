using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnalysisForVotingRegions
{
    class Program
    {
        static void Main(string[] args)
        {
            AnalyticsTool analyticsTool = new AnalyticsTool();
            //Console.WriteLine(analyticsTool.FindMinimalNumberCouncilMembersForEachRuralMunicipality());
            //Console.WriteLine(analyticsTool.FindMunicipalityWithLowestAndHigestEVotePercentage());
            //Console.WriteLine(analyticsTool.FindMunicipalityWithLowestAndHigestPaperVotePercentage());
            //Console.WriteLine(analyticsTool.FindRegionWithHighestAndLowestVotingActivity());
            //Console.WriteLine(analyticsTool.GetVotingActitityAndPercentageOfVotes("hiiu"));
            //Console.WriteLine(analyticsTool.PrintInfoForAllRegions());
            //Console.WriteLine(analyticsTool.FindRegionWithHighestAndLowestPercentageOfCitizensWithTheRightToVote());
            //Console.WriteLine(analyticsTool.FindIfElectionsAreHeld(1922));
            //Console.WriteLine(analyticsTool.FindIfPersonCouldVoteOrStandAsCandidate("60509113456"));
            //Console.WriteLine(analyticsTool.CreateAccountNameAndSave("HöövelÜ Jäääääar"));
            //Console.WriteLine(analyticsTool.FindBiggestWinnersAndLosers());

            DetailedAnalyticsTool detailedAnalyticsToolForTallinn = new DetailedAnalyticsTool("Tallinn_region2_results.csv", ",");
            Console.WriteLine(detailedAnalyticsToolForTallinn.FindTotalNumberOfVotesForParty("reform"));
            Console.WriteLine(detailedAnalyticsToolForTallinn.FoundPersonWithLeastAndMostVotes("Eesti reformierakond"));
            Console.WriteLine(detailedAnalyticsToolForTallinn.FindPersonsWithZeroVotes());
            Console.WriteLine(detailedAnalyticsToolForTallinn.FindCandidatesWithPersonalMandate());
            detailedAnalyticsToolForTallinn.CreateAccountNameAndSaveForEveryCandidate();

            DetailedAnalyticsTool detailedAnalyticsToolForSaue = new DetailedAnalyticsTool("SaueRegionResults.csv", ";");
            Console.WriteLine(detailedAnalyticsToolForSaue.FindTotalNumberOfVotesForParty("reform"));
            Console.WriteLine(detailedAnalyticsToolForSaue.FoundPersonWithLeastAndMostVotes("Eesti reformierakond"));
            Console.WriteLine(detailedAnalyticsToolForSaue.FindPersonsWithZeroVotes());
            Console.WriteLine(detailedAnalyticsToolForSaue.FindCandidatesWithPersonalMandate());
            detailedAnalyticsToolForSaue.CreateAccountNameAndSaveForEveryCandidate();
        }   
    }
}
