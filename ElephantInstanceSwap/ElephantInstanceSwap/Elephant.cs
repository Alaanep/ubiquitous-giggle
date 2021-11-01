using System;
namespace ElephantInstanceSwap
{
    public class Elephant
    {
        private string _name;
        private int _earSize;
        public Elephant(string name, int earSize)
        {
            _name = name;
            _earSize = earSize;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value;  }
        }

        public void WhoAmi()
        {
            Console.WriteLine($"My name is {_name}");
            Console.WriteLine($"My ears are {_earSize} inches tall");
            Console.WriteLine();
        }

        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine($"{_name} heared a message");
            Console.WriteLine($"{whoSaidIt._name} said this: {message}");
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}
