using Microsoft.VisualStudio.TestTools.UnitTesting;
using EX2;

namespace VatCalculatorTest
{
    [TestClass]
    public class VatCalculatorTests
    {
        VatCalculator vatCalculator;

        [TestInitialize]
        public void TestInitialize()
        {
            vatCalculator = new VatCalculator();
        }

        [TestMethod]
        public void TestDefaultVatRate_20_02()
        {
            Assert.AreEqual(vatCalculator.VatRate, 0.2);
        }

        [TestMethod]
        public void TestSetVatRate_30_03()
        {
            vatCalculator.SetVatRate(30);
            Assert.AreEqual(0.3, vatCalculator.VatRate);
        }

        [TestMethod]
        public void TestFindVat_20_4()
        {
            double result = vatCalculator.FindVat(20);
            Assert.AreEqual(4, result, 0.01);
        }

        [TestMethod]
        public void TestFindVat_13_260()
        {
            double result = vatCalculator.FindVat(13);
            Assert.AreEqual(2.6, result, 0.01);
        }

        [TestMethod]
        public void TestFindPrice_true_20_1667()
        {
            double result = vatCalculator.FindPrice(true, 20);
            Assert.AreEqual( 16.67, result, 0.01);
        }

        [TestMethod]
        public void TestFindPrice_false_20_24()
        {
            double result = vatCalculator.FindPrice(false, 20);
            Assert.AreEqual(24, result, 0.01);
        }

        [TestMethod]
        public void TestFindPrice_false_1353_162()
        {
            double result = vatCalculator.FindPrice(false, 1.353);
            Assert.AreEqual(1.62, result, 0.01);
        }

        [TestMethod]
        public void TestFindPriceBasedOnTax_4_20()
        {
            double result = vatCalculator.FindPriceBasedOnTax(4);
            Assert.AreEqual(20, result, 0.01);
        }

        [TestMethod]
        public void TestFindPriceBasedOnTax_633_3165()
        {
            double result = vatCalculator.FindPriceBasedOnTax(6.33);
            Assert.AreEqual(31.65, result, 0.01);
        }

        [TestMethod]
        public void TestIsTaxPercent20_02_true()
        {
            Assert.IsTrue(vatCalculator.IsTaxPercent20());
        }

        [TestMethod]
        public void TestIsTaxPercent20_03_false()
        {
            vatCalculator.SetVatRate(30);
            Assert.IsFalse(vatCalculator.IsTaxPercent20());
        }
    }
}
