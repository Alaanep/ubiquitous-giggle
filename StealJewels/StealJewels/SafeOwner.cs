using System;
namespace StealJewels
{
    public class SafeOwner
    {
        private string valuables = "";
        public void ReceiveContents(string safeContents)
        {
            valuables = safeContents;
            Console.WriteLine($"Thank you for returning my {valuables}");
        }
        public SafeOwner()
        {
        }
    }
}
