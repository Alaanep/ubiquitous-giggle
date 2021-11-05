using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxCalculator_WITHOUT_PROPERTIES;

namespace TaxCalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        //create TaxCalc class object
        public TaxCalculator tc = new TaxCalculator();

        //We do not need TestInitialize method here because we have different
        //values for each test
        [TestMethod]
        public void TestAddingYearlyIncome()
        {
            tc.AddYearlyIncome(5000);
            Assert.AreEqual(5000.0,
                tc.GetYearlyIncome(), 0.1);
        }

        [TestMethod]
        public void TestAddingMonhtlyIncome()
        {
            tc.AddMontlhyIncome(1000);
            Assert.AreEqual(12000.0,
                tc.GetYearlyIncome(), 0.1);
        }

        [TestMethod]
        public void Test_FindYearlyTaxfree_14400()
        {
            //if yeary is less than 14400 then free is 6000
            tc.AddYearlyIncome(13000);
            tc.FindYearlyTaxFreeIncome();
            Assert.AreEqual(6000,
                tc.FindYearlyTaxFreeIncome());
        }

        [TestMethod]
        public void Test_FindYearlyTaxfree_20000()
        {
            tc.AddYearlyIncome(20000);
            tc.FindYearlyTaxFreeIncome();
            Assert.AreEqual(2888.89,
                tc.FindYearlyTaxFreeIncome(), 0.1);
        }

        [TestMethod]
        public void Test_FindYearlyTaxfree_26000()
        {
            tc.AddYearlyIncome(26000);
            tc.FindYearlyTaxFreeIncome();
            Assert.AreEqual(0,
                tc.FindYearlyTaxFreeIncome(), 0.1);
        }


        [TestMethod]
        public void Test_FindMonthlyTaxfree_960()
        {
            tc.AddMontlhyIncome(960);
            tc.FindMonthlyTaxFreeIncome();
            Assert.AreEqual(500,
                tc.FindMonthlyTaxFreeIncome(), 0.1);
        }
    }
}