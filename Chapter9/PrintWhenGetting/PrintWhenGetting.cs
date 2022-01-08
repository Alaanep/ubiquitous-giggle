using System;
namespace PrintWhenGetting
{
    public class PrintWhenGetting
    {
        public PrintWhenGetting()
        {
        }

        private int instanceNumber;
        public int InstanceNumber
        {
            set { instanceNumber = value; }
            get {
                Console.WriteLine($"Getting #{instanceNumber}");
                return instanceNumber;
            }
        }
    }
}
