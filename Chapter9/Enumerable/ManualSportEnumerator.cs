using System;
using System.Collections.Generic;
namespace Enumerable
{
    public class ManualSportEnumerator: IEnumerator<Sport>
    {
        int current = -1;

        public Sport Current { get { return (Sport)current; } }
        public void Dispose() { return; }
        object System.Collections.IEnumerator.Current {  get { return current;  } }

        public bool MoveNext()
        {
            var maxEnumValue = Enum.GetValues(typeof(Sport)).Length;
            if((int)current >= maxEnumValue - 1) { return false; }
            current++;
            return true;
        }

        public void Reset() { current = 0; }
        public ManualSportEnumerator()
        {
        }
    }
}
