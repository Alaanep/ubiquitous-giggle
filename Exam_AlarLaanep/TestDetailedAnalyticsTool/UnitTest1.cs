using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalysisForVotingRegions;
namespace TestDetailedAnalyticsTool
{
    [TestClass]
    public class UnitTest1
    {
        DetailedAnalyticsTool detailedAnalyticsTool = new DetailedAnalyticsTool("Tallinn_region2_results.csv", ",");

        [TestMethod]
        public void Test_FindTotalNumberOfVotesForParty_Reform_7046()
        {
            string result = detailedAnalyticsTool.FindTotalNumberOfVotesForParty("reform");
            string expectedResult = "Eesti reformierakond-> 7046";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FoundPersonWithLeastAndMostVotes_Reform()
        {
            string result = detailedAnalyticsTool.FoundPersonWithLeastAndMostVotes("Reform");
            string expectedResult = "Eesti reformierakond-> KEIT PENTUS-ROSIMANNUS (3586), RAINAR ENDEN (38)";
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Test_FindCandidatesWithPersonalMandate()
        {
            string result = detailedAnalyticsTool.FindCandidatesWithPersonalMandate();
            string expectedResult = "KEIT PENTUS-ROSIMANNUS Eesti reformierakond 3586\n";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindPersonsWithZeroVotes()
        {
            string result = detailedAnalyticsTool.FindPersonsWithZeroVotes();
            string expectedResult = "MARJE LIIGUS\n" +
                                    "MARKO PEEK\n" +
                                    "HANNA-LISETT KOPPEL\n" +
                                    "ANTS TEPPE\n" +
                                    "RAIMOND ERNST LEITARU\n" +
                                    "ARVI KÄÄRD\n" +
                                    "ERIK SIMIN\n" +
                                    "SOFIA NEDOREZOVA\n" +
                                    "ARGO MALLA\n" +
                                    "SVEN MÄSES\n";
            Assert.AreEqual(expectedResult, result);
        }

        

        

        [TestMethod]
        public void Test_GetSimpleQuota_2610()
        {
            int result = detailedAnalyticsTool.GetSimpleQuota(",");
            int expectedResult = 2610;
            Assert.AreEqual(expectedResult, result);
        }


    }
}
