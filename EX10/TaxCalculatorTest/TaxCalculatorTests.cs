using Microsoft.VisualStudio.TestTools.UnitTesting;
using EX3;
namespace TaxCalculatorTest
{
    [TestClass]
    public class TaxCalculatorTests
    {
        TaxCalculator taxCalculator;

        [TestInitialize]
        public void TestInitialize()
        {
            taxCalculator = new TaxCalculator();
            taxCalculator.AddYearlyIncome(20000);
        }

        [TestMethod]
        public void TestAddMonthlyIncome_100_1200()
        {
            taxCalculator.AddMonthlyIncome(100);
            double result = taxCalculator.YearlySalary;
            Assert.AreEqual(result, 1200);
        }

        [TestMethod]
        public void TestAddMonthlyIncome_negative_5_0()
        {
            taxCalculator.AddMonthlyIncome(-5);
            double result = taxCalculator.YearlySalary;
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void TestAddYearlyIncome_negative_5_0()
        {
            taxCalculator.AddYearlyIncome(-5);
            double result = taxCalculator.YearlySalary;
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void TestAddYearlyIncome_20000_20000()
        {
            taxCalculator.AddYearlyIncome(20000);
            double result = taxCalculator.YearlySalary;
            Assert.AreEqual(result, 20000);
        }

        [TestMethod]
        public void TestFindYearlyTaxFreeAmount_20000_2888_89()
        {
            taxCalculator.AddYearlyIncome(20000);
            double result = taxCalculator.FindYearlyTaxFreeAmount();
            Assert.AreEqual(result, 2888.89, 0.03);
        }

        [TestMethod]
        public void TestFindYearlyTaxFreeAmount_13999_6000()
        {
            taxCalculator.AddYearlyIncome(13499);
            double result = taxCalculator.FindYearlyTaxFreeAmount();
            Assert.AreEqual(result, 6000, 0.03);
        }

        [TestMethod]
        public void TestFindYearlyTaxFreeAmount_25200_0()
        {
            taxCalculator.AddYearlyIncome(25200);
            double result = taxCalculator.FindYearlyTaxFreeAmount();
            Assert.AreEqual(result, 0, 0.03);
        }


    }
}
