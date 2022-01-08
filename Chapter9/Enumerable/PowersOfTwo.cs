using System;
using System.Collections.Generic;
namespace Enumerable
{
    public class PowersOfTwo: IEnumerable<int>
    {
        public PowersOfTwo()
        {
        }

        public IEnumerator<int> GetEnumerator()
        {
            var maxPower = Math.Round(Math.Log(int.MaxValue), 2);
            for(int power = 0; power < maxPower; power++)
            {
                yield return (int)Math.Pow(2, power);
            }   
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
       
    }
}
