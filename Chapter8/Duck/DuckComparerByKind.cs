using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Duck
{
    public class DuckComparerByKind : IComparer<Duck>
    {
        public DuckComparerByKind()
        {
        }

        public int Compare(Duck x, Duck y)
        {
            if (x.Kind < y.Kind)
            {
                return -1;
            }
            if (x.Kind > y.Kind)
            {
                return 1;
            }
            return 0;
        }
    }
}
