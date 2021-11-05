using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxCalculatorClass;

namespace TaxCalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        //create TaxCalc class object
        public TaxCalc tc = new TaxCalc();
        
        //We do not need TestInitialize method here because we have different values for each test

        [TestMethod]
        public void AddYearlyIncome_5000()
        {
            tc.AddYearlyIncome(5000);
            Assert.AreEqual(5000.0, 
                tc.YearlyIncome, 0.1);
        }

        [TestMethod]
        public void AddMonthlyIncome_TestYearlyIncome_1000_12000()
        {
            tc.AddMonthlyIncome(1000);
            Assert.AreEqual(12000.0, 
                tc.YearlyIncome, 0.1);
        }

        [TestMethod]
        public void FindYearlyTaxFree_14400_6000()
        {
            //If yearly is less than 14400 then tax free is 6000

            //We must add new yearly income in every test: values from previous tests are not saved
            
            
            
            tc.AddYearlyIncome(13000); //1. add yearly income
            tc.FindYearlyTaxFreeIncome(); //2. call method for finding yearly tax free
            Assert.AreEqual(6000, 
                tc.YearlyTaxFree); //3. test value
        }

        [TestMethod]
        public void FindYearlyTaxFree_20000_2888()
        {
            tc.AddYearlyIncome(20000);
            tc.FindYearlyTaxFreeIncome();
            Assert.AreEqual(2888.89,
                tc.YearlyTaxFree, 0.1);
        }

        [TestMethod]
        public void FindYearlyTaxFree_26000()
        {
            tc.AddYearlyIncome(26000); 
            tc.FindYearlyTaxFreeIncome();
            Assert.AreEqual(0, 
                tc.YearlyTaxFree, 0.1);
        }


        [TestMethod]
        public void FindMonthlyTaxFree_960_500()
        {
            tc.AddMonthlyIncome(960);
            tc.FindMonthlyTaxFreeIncome();
            Assert.AreEqual(500,
                tc.MonthlyTaxFree, 0.1);
        }
    }
}
