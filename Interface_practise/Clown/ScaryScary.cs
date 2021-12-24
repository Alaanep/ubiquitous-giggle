using System;
namespace Clown
{
    public class ScaryScary: FunnyFunny, IScaryClown
    {
        private readonly int _scaryThingCount;

        public ScaryScary(string funnyThing, int scaryThingCount) : base(funnyThing)
        {
            this._scaryThingCount = scaryThingCount;
            
        }

        public string ScaryThingIHave {
                get { return $"{_scaryThingCount} spiders"; }
        }


        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo! Gotcha! Look  at my {ScaryThingIHave}");
        }
    }
}
