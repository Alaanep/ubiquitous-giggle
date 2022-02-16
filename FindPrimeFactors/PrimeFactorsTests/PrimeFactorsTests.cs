using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindPrimeFactors;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFactorsTests
{
    [TestClass]
    public class PrimeFactorsTest
    {
        private PrimeFactors primeFactors;
        [TestInitialize]
        public void Initialize() {
            primeFactors = new PrimeFactors();

        }


        [TestMethod]
        public void CanCreatePrimeFactors()
        {
            PrimeFactors primeFactors = new PrimeFactors();
        }

        [TestMethod]
        public void FactorsOf1()
        {
            Assert.AreEqual(false, primeFactors.FactorsOf(1).Any());
        }
        [TestMethod]
        public void FactorsOf2()
        {
            Assert.IsTrue(primeFactors.FactorsOf(2).Contains(2));
        }

        [TestMethod]
        public void FactorsOf3()
        {
            Assert.IsTrue(primeFactors.FactorsOf(3).Contains(3));
        }

        [TestMethod]
        public void FactorsOf4()
        {
            List<int> testList = new List<int>() { 2, 2 };
            Assert.IsTrue(primeFactors.FactorsOf(4).SequenceEqual(testList));
        }

        [TestMethod]
        public void FactorsOf5()
        {
            Assert.IsTrue(primeFactors.FactorsOf(5).Contains(5));
        }

        [TestMethod]
        public void FactorsOf6()
        {
            List<int> testList = new List<int>() {2,3};
            Assert.IsTrue(primeFactors.FactorsOf(6).SequenceEqual(testList));
        }

        [TestMethod]
        public void FactorsOf7()
        {
            Assert.IsTrue(primeFactors.FactorsOf(7).Contains(7));
        }

        [TestMethod]
        public void FactorsOf8()
        {
            List<int> testList = new List<int>() {2,2,2};
            Assert.IsTrue(primeFactors.FactorsOf(8).SequenceEqual(testList));
        }

        [TestMethod]
        public void FactorsOf9()
        {
            List<int> testList = new List<int>() {3,3};
            Assert.IsTrue(primeFactors.FactorsOf(9).SequenceEqual(testList));
        }

        [TestMethod]
        public void FactorsOf10()
        {
            List<int> testList = new List<int>() { 2, 5 };
            Assert.IsTrue(primeFactors.FactorsOf(10).SequenceEqual(testList));
        }

        [TestMethod]
        public void FactorsOf90()
        {
            List<int> testList = new List<int>() {2,3,3,5 };
            Assert.IsTrue(primeFactors.FactorsOf(90).SequenceEqual(testList));
        }
    }
}
