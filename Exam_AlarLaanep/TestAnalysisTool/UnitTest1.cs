using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalysisForVotingRegions;


namespace TestAnalysisTool
{
    [TestClass]
    public class UnitTest1
    {
        AnalyticsTool analyticsTool = new AnalyticsTool();

        [TestMethod]
        public void Test_GetMinimalNumberCouncilMembers_1500_7()
        {
            int result = analyticsTool.GetMinimalNumberCouncilMembers(1500);
            int expectedResult = 7;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_GetMinimalNumberCouncilMembers_500000_79()
        {
            int result = analyticsTool.GetMinimalNumberCouncilMembers(500000);
            int expectedResult = 79;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_GetMinimalNumberCouncilMembers_7501_19()
        {
            int result = analyticsTool.GetMinimalNumberCouncilMembers(7501);
            int expectedResult = 19;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindHighestPercentage_EVotes_56_7()
        {
            double result = analyticsTool.FindHighestPercentage("E-häälte arv", "Paberil häälte arv", "E-häälte arv");
            double expectedResult = 56.7;
            Assert.AreEqual(expectedResult, result, 0.1);
        }

        [TestMethod]
        public void Test_FindMunicipalityWithHighestPercentage_EVotes_Hiiu_maakond()
        {
            string result = analyticsTool.FindMunicipalityWithHighestPercentage("E-häälte arv", "Paberil häälte arv", "E-häälte arv");
            string expectedResult = "Hiiu maakond";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindLowestPercentage_EVotes_35()
        {
            double result = analyticsTool.FindLowestPercentage("E-häälte arv", "Paberil häälte arv", "E-häälte arv");
            double expectedResult = 35;
            Assert.AreEqual(expectedResult, result, 0.1);
        }

        [TestMethod]
        public void Test_FindMunicipalityWithLowestPercentage_EVotes_Ida_Viru_maakond()
        {
            string result = analyticsTool.FindMunicipalityWithLowestPercentage("E-häälte arv", "Paberil häälte arv", "E-häälte arv");
            string expectedResult = "Ida-Viru maakond";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindHighestPercentage_PaperVotes_65()
        {
            double result = analyticsTool.FindHighestPercentage("Paberil häälte arv", "Paberil häälte arv", "E-häälte arv");
            double expectedResult = 65;
            Assert.AreEqual(expectedResult, result, 0.1);
        }

        [TestMethod]
        public void Test_FindMunicipalityWithHigestPercentage_PaperVotes_Ida_Viru_maakond()
        {
            string result = analyticsTool.FindMunicipalityWithHighestPercentage("Paberil häälte arv", "Paberil häälte arv", "E-häälte arv");
            string expectedResult = "Ida-Viru maakond";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindLowestPercentage_PaperVotes_43_3()
        {
            double result = analyticsTool.FindLowestPercentage("Paberil häälte arv", "Paberil häälte arv", "E-häälte arv");
            double expectedResult = 43.3;
            Assert.AreEqual(expectedResult, result, 0.1);
        }

        [TestMethod]
        public void Test_FindMunicipalityWithLowestPercentage_PaperVotes_Hiiu_maakond()
        {
            string result = analyticsTool.FindMunicipalityWithLowestPercentage("Paberil häälte arv", "Paberil häälte arv", "E-häälte arv");
            string expectedResult = "Hiiu maakond";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindHighestVotingActivity_59_3()
        {
            double result = analyticsTool.FindHighestPercentage("Hääleõiguslikke kodanikke", "Paberil häälte arv", "E-häälte arv", false);
            double expectedResult = 59.3;
            Assert.AreEqual(expectedResult, result, 0.1);
        }

        [TestMethod]
        public void Test_FindmunicipalityWithHighestVotingActivity_Jõgeva_maakond()
        {
            string result = analyticsTool.FindMunicipalityWithHighestPercentage("Hääleõiguslikke kodanikke", "Paberil häälte arv", "E-häälte arv", false);
            string expectedResult = "Jõgeva maakond";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindLowestVotingActivity_47_3()
        {
            double result = analyticsTool.FindLowestPercentage("Hääleõiguslikke kodanikke", "Paberil häälte arv", "E-häälte arv", false);
            double expectedResult = 47.3;
            Assert.AreEqual(expectedResult, result, 0.1);
        }

        [TestMethod]
        public void Test_FindmunicipalityWithLowestVotingActivity_Ida_Viru_maakond()
        {
            string result = analyticsTool.FindMunicipalityWithLowestPercentage("Hääleõiguslikke kodanikke", "Paberil häälte arv", "E-häälte arv", false);
            string expectedResult = "Ida-Viru maakond";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_GetVotingActitityAndPercentageOfVotes_Soome_notfound()
        {
            string result = analyticsTool.GetVotingActitityAndPercentageOfVotes("Soome");
            string expectedResult = "Could not found info based on Soome";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_GetVotingActitityAndPercentageOfVotes_Hiiu_notfound()
        {
            string result = analyticsTool.GetVotingActitityAndPercentageOfVotes("Hiiu");
            string expectedResult = "Hiiu maakond-> Valimisaktiivsus on 58.9%, e-häälte osakaal on 56.7% ning paberhäälte osakaal 43.3%";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_GetVotingActitityAndPercentageOfVotes_hiiu_notfound()
        {
            string result = analyticsTool.GetVotingActitityAndPercentageOfVotes("Hiiu");
            string expectedResult = "Hiiu maakond-> Valimisaktiivsus on 58.9%, e-häälte osakaal on 56.7% ning paberhäälte osakaal 43.3%";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindRegionWithHighestAndLowestPercentageOfCitizensWithTheRightToVote()
        {
            string result = analyticsTool.FindRegionWithHighestAndLowestPercentageOfCitizensWithTheRightToVote();
            string expectedResult = "Highest perctange of citizens with right to vote was in Hiiu maakond with 88.4% of citizen right to vote\n"+
            "Lowest perctange of citizens with right to vote was in Harju maakond with 76.6% of citizen right to vote\n";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindIfElectionsAreHeld_2050_no()
        {
            string result = analyticsTool.FindIfElectionsAreHeld(2050);
            string expectedResult = "No elections on 2050. Previous elections 2021. Next elections should be held in 2025";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindIfElectionsAreHeld_2021_Yes()
        {
            string result = analyticsTool.FindIfElectionsAreHeld(2021);
            string expectedResult = "Elections are being held in 2021";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindIfElectionsAreHeld_1900_no()
        {
            string result = analyticsTool.FindIfElectionsAreHeld(1900);
            string expectedResult = "No elections on 1900. No previous elections. Elections were held first time in 1921.";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindIfElectionsAreHeld_2008_no()
        {
            string result = analyticsTool.FindIfElectionsAreHeld(2008);
            string expectedResult = "No elections on 2008. Prevoius elections: 2005. Next elections 2009";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindIfPersonCouldVoteOrStandAsCandidate_48803214480_YES()
        {
            string result = analyticsTool.FindIfPersonCouldVoteOrStandAsCandidate("48803214480");
            string expectedResult = "48803214480 -> Hääletada saab, kandideerida saab.";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindIfPersonCouldVoteOrStandAsCandidate_61512311560_NO()
        {
            string result = analyticsTool.FindIfPersonCouldVoteOrStandAsCandidate("61512311560");
            string expectedResult = "61512311560 -> Hääletada ei saa, kandideerida ei saa.";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindIfPersonCouldVoteOrStandAsCandidate_3340121459_Invalid()
        {
            string result = analyticsTool.FindIfPersonCouldVoteOrStandAsCandidate("3340121459");
            string expectedResult = "Invalid personalcode";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FindIfPersonCouldVoteOrStandAsCandidate_60509113459_Invalid()
        {
            string result = analyticsTool.FindIfPersonCouldVoteOrStandAsCandidate("3340121459");
            string expectedResult = "Invalid personalcode";
            Assert.AreEqual(expectedResult, result);
        }

        
        [TestMethod]
        public void Test_FindIfPersonCouldVoteOrStandAsCandidate_60509113456_YesNo()
        {
            string result = analyticsTool.FindIfPersonCouldVoteOrStandAsCandidate("60509113456");
            string expectedResult = "60509113456 -> Hääletada saab, kandideerida ei saa";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_CreateAccountNameAndSave_HöövelÜ_Jäääääar_hoovel_jaaaaa()
        {
            string result = analyticsTool.CreateAccountNameAndSave("HöövelÜ Jäääääar");
            string expectedResult = "hoovel.jaaaaa";
            Assert.AreEqual(expectedResult, result);
        }
        
        [TestMethod]
        public void Test_CreateAccountNameAndSave_RUDOLF_KASPER_NARUSKI_rud_kas_narusk()
        {
            string result = analyticsTool.CreateAccountNameAndSave("RUDOLF KASPER NARUSKI");
            string expectedResult = "rud.kas.narusk";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_CreateAccountNameAndSave_RUDOLF_invalid()
        {
            string result = analyticsTool.CreateAccountNameAndSave("RUDOLF");
            string expectedResult = "For account name please enter firstname and lastname";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FindBiggestWinnersAndLosers() {
            string result = analyticsTool.FindBiggestWinnersAndLosers();
            string expectedResult = "Biggest winner was Reformierakond with 8 more places than expected.\n" +
            "Biggest loser was EKRE with 4 places less than expected.\n";
            Assert.AreEqual(expectedResult, result);
        }


    }
}
