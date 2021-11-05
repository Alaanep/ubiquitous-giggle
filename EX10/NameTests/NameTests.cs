using Microsoft.VisualStudio.TestTools.UnitTesting;
using EX1;

namespace NameTest
{
    [TestClass]
    public class NameTests
    {
        public NameManipulator nameManipulator;
        [TestInitialize]
        public void TestInitialize()
        {
            nameManipulator = new NameManipulator();
            nameManipulator.AddName("Mari");

        }
        [TestMethod]
        public void CapitalizeName_mari_Mari()
        {
            string result = nameManipulator.CapitalizeName();
            Assert.AreEqual("MARI", result);
        }
        [TestMethod]
        public void GetNameLength_Mari_4()
        {
            int result = nameManipulator.GetNameLength();
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void ReplaceVowels_Mari_Mxrx()
        {
            string result = nameManipulator.ReplaceVowel();
            Assert.AreEqual("Mxrx", result);
        }

        [TestMethod]
        public void ReplaceVowels_Anu_xnx()
        {
            nameManipulator.AddName("Anu");
            string result = nameManipulator.ReplaceVowel();
            Assert.AreEqual("xnx", result);
        }

    }
}
