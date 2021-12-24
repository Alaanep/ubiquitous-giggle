using System;
namespace Clown
{
    public class FunnyFunny: IClown
    {
        private string _funnyThingIHave;

        public string FunnyThingIHave
        {
            get { return _funnyThingIHave; }
        }

        public FunnyFunny(string funnyThing)
        {
            this._funnyThingIHave = funnyThing;
        }

        public void Honk()
        {
            Console.WriteLine($"Hi Kids! I have a {FunnyThingIHave}.");
        }
    }
}
