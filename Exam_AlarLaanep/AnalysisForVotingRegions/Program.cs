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
            Console.WriteLine(analyticsTool.FindIfElectionsAreHeld(1922));
            //Console.WriteLine(analyticsTool.FindIfPersonCouldVoteOrStandAsCandidate("60509113456"));
            //Console.WriteLine(analyticsTool.CreateAccountNameAndSave("HöövelÜ Jäääääar"));
            //Console.WriteLine(analyticsTool.FindBiggestWinnersAndLosers());

            //DetailedAnalyticsTool detailedAnalyticsTool = new DetailedAnalyticsTool();
            //Console.WriteLine(detailedAnalyticsTool.FindTotalNumberOfVotesForParty("reform"));
            //Console.WriteLine(detailedAnalyticsTool.FoundPersonWithLeastAndMostVotes("Eesti reformierakond"));
            //Console.WriteLine(detailedAnalyticsTool.FindPersonsWithZeroVotes());
            //Console.WriteLine(detailedAnalyticsTool.FindCandidatesWithPersonalMandate());
        }   
    }
}
