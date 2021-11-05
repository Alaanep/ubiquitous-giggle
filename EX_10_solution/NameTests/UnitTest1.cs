using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex1; //EX1 namespace; with resharper imported automatically

namespace NameTests
{
    [TestClass]
    public class UnitTest1
    {
        public NameManipulator nm;

        
        [TestInitialize]//This is called before each test!
        public void TestInitialize()
        {
            nm = new NameManipulator();
            nm.AddName("Mari");
        }
        [TestMethod]
        public void CapitalizeName_mari_MARI()
        {
            string result = nm.CapitalizeName();
            Assert.AreEqual(result, "MARI");
        }

        [TestMethod]
        public void GetNameLength_Mari_4()
        {
            int result = nm.GetNameLength();
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void ReplaceVowels_Mari_Mxrx()
        {
            string result = nm.ReplaceVowels();
            Assert.AreEqual("Mxrx", result);
        }

        [TestMethod]
        public void ReplaceVowels_ANU_xNx()
        {
            nm.AddName("ANU"); //change name to ANU
            string result = nm.ReplaceVowels();
            Assert.AreEqual("xNx", result);
        }
    }
}
