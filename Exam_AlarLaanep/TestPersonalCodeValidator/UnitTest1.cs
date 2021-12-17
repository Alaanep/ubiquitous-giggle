using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalysisForVotingRegions;

namespace TestPersonalCodeValidator
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Test_CheckAllDigits_123456789ac_false()
        {
            bool result = PersonalCodeValidator.CheckAllDigits("123456789ac");
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_CheckLength_12345678910_true()
        {
            bool result = PersonalCodeValidator.CheckLength("12345678910");
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_CheckLength_1234567891_false()
        {
            bool result = PersonalCodeValidator.CheckLength("1234567891");
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_CheckFirstCharRange_38505250269_true()
        {
            bool result = PersonalCodeValidator.CheckFirstCharRange("38505250269");
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_CheckFirstCharRange_98505250269_false()
        {
            bool result = PersonalCodeValidator.CheckFirstCharRange("98505250269");
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, result);
        }


    }
}
