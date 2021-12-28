using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Duck
{
    public class DuckComparer: IComparer<Duck>
    {
        public DuckComparer()
        {
        }

        public SortCriteria SortBy = SortCriteria.sizeThenKind;

        public int Compare(Duck x, Duck y)
        {
            if (SortBy == SortCriteria.sizeThenKind)
            {
                if (x.Size < y.Size)
                {
                    return -1;
                }
                else if (x.Size > y.Size)
                {
                    return 1;
                }
                else
                {
                    if (x.Kind < y.Kind)
                    {
                        return -1;
                    }
                    else if (x.Kind > y.Kind)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            else
            {
                if (x.Kind < y.Kind)
                {
                    return -1;
                }
                else if (x.Kind > y.Kind)
                {
                    return 1;
                }
                else
                {
                    if (x.Size < y.Size)
                    {
                        return -1;
                    }
                    else if (x.Size > y.Size)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
