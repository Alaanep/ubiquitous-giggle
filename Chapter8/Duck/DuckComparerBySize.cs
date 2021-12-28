using System;
using System.Collections.Generic;
namespace Duck
{
    public class DuckComparerBySize: IComparer<Duck>
    {
        public DuckComparerBySize()
        {
        }

        public int Compare(Duck x, Duck y)
        {
            if(x.Size < y.Size)
            {
                return -1;
            }
            if(x.Size > y.Size)
            {
                return 1;
            }
            return 0;
        }
    }
}
