using ClassExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private NumbersList numbersList = new NumbersList();

        [TestInitialize]
        public void TestInitialize()
        {
            numbersList.AddListItems(2);
            numbersList.AddListItems(3);
            numbersList.AddListItems(5);
        }

        [TestMethod]
        public void AddListItems_Count_3()
        {
            Assert.AreEqual(3, numbersList.GetListLength()); 
        }

        [TestMethod]
        public void AddListItems_110_invalid()
        {
            numbersList.AddListItems(110); //invalid value
            //count should not change
            Assert.AreEqual(3, numbersList.GetListLength()); 
        }

        [TestMethod]
        public void FindSumOfListItems_235_10()
        {
            Assert.AreEqual(10, numbersList.FindSumOfListItems()); 
        }

        [TestMethod]
        public void FindMiddleListItem_235_3()
        {
            Assert.AreEqual(3, numbersList.FindMiddleListItem()); 
        }

        [TestMethod]
        public void FindMiddleListItem_empty_0()
        {
            numbersList.ClearList();
            Assert.AreEqual(0, numbersList.FindMiddleListItem());
        }
    }
}
