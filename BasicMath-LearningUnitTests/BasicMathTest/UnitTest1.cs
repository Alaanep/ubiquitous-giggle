using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath_LearningUnitTests;

namespace BasicMathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.Add(10, 10);
            Assert.AreEqual(result, 20);
        }

        [TestMethod]
        public void TestSubtractMethod()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.Subtract(10, 10);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void TestDivideMethod()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.Divide(10, 5);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.Multiply(10, 10);
            Assert.AreEqual(result, 100);
        }



    }
}
