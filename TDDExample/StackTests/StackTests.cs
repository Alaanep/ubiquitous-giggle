using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDExample;

namespace StackTests
{
    [TestClass]
    public class StackTests
    {
        Stack myStack;

        [TestInitialize]
        public void TestInitialize()
        {
           myStack = new Stack();
        }

        [TestMethod]
        public void CanCreateStack()
        {
            
            Assert.IsTrue(myStack.IsEmpty());
        }

        [TestMethod]
        public void AfterOnePush_IsNotEmpty()
        {
 
            myStack.Push(0);
            Assert.IsFalse(myStack.IsEmpty());
        }

        [TestMethod]
        public void AfterOnePushAndOnePop_IsEmpty()
        {
            myStack.Push(0);
            myStack.Pop();
            Assert.IsTrue(myStack.IsEmpty());
        }

        [TestMethod]
        public void AfterTwoPushes_SizeIs2()
        {
            myStack.Push(0);
            myStack.Push(0);
            Assert.AreEqual(2, myStack.GetSize());
        }

        [TestMethod]
        public void PopEmptyStack_SizeIs0()
        {
            myStack.Pop();
            Assert.AreEqual(0, myStack.GetSize());
        }

        [TestMethod]
        public void AfterPushing3_WillPop3()
        {
            myStack.Push(3);
            Assert.AreEqual(3, myStack.Pop());
        }

        [TestMethod]
        public void PopingEmptyStack_ReturnsNull()
        {
            ;
            Assert.AreEqual(null, myStack.Pop());
        }
    }
}
