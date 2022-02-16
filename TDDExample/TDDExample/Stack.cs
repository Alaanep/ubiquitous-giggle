using System;
using System.Collections;
using System.Collections.Generic;
namespace TDDExample
{
    public class Stack
    {
        private List<int> myStack;
        
        public Stack()
        {
            
            myStack = new List<int>();

        }

        public bool IsEmpty() => myStack.Count==0;

        public void Push(int element)
        {
            myStack.Add(element);
            
        }

        public int? Pop()
        {
            int? lastPush = null;
            if (myStack.Count >= 1) {
                lastPush = myStack[myStack.Count - 1];
                myStack.RemoveAt(myStack.Count - 1);

            }
            return lastPush;
            
        }

        public int GetSize() => myStack.Count;
    }
}
