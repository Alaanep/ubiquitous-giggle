using System;
using System.Diagnostics.CodeAnalysis;

namespace CardLinq
{
    public class Card: IComparable<Card>
    {
        public Values Value { get; private set; }
        public Suits Suit { get; private set; }
        
        public Card(Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public string Name
        {
            get { return $"{Value} of {Suit}"; }
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo( Card other)
        {
            return new CardComparer().Compare(this, other);
        }
    }
}
