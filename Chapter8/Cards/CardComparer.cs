using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Cards
{
    public class CardComparer : IComparer<Card>
    {
        public CardComparer()
        {
        }

        public int Compare(Card x, Card y)
        {
            if(x.Suit < y.Suit)
            {
                return -1;
            }
            if(x.Suit > y.Suit)
            {
                return 1;
            }
            if(x.Value > y.Value)
            {
                return 1;
            }
            if(x.Value<y.Value){
                return -1;
            }
            return 0;
        }
    }
}
