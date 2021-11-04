using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;
namespace BasicMathTDDTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.Add(20.50, 20.50);
            Assert.AreEqual(41, result);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.Multiply(10,10);
            Assert.AreEqual(100, result);
        }
    }
}
