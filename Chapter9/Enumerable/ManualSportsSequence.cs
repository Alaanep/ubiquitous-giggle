using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumerable
{
    public class ManualSportsSequence : IEnumerable<Sport>
    {
        public ManualSportsSequence()
        {
        }

        public IEnumerator<Sport> GetEnumerator()
        {
            return new ManualSportEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
