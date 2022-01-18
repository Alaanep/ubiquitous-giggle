using System;
using System.Collections.Generic;
using System.IO;

namespace Cards
{
    public class Deck : List<Card>
    {
        private static Random random = new Random();

        public Deck()
        {
            Reset();
        }

        public Deck(string fileName)
        {
            Clear();
            using(StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    var nextCard = reader.ReadLine();
                    var cardParts = nextCard.Split(new char[] { ' ' });

                    var value = cardParts[0] switch
                    {
                        "Ace" => Values.Ace,
                        "Two" => Values.Two,
                        "Three" => Values.Three,
                        "Four" => Values.Four,
                        "Five" => Values.Five,
                        "Six" => Values.Six,
                        "Seven" => Values.Seven,
                        "Eight" => Values.Eight,
                        "Nine" => Values.Nine,
                        "Ten" => Values.Ten,
                        "Jack" => Values.Jack,
                        "Queen" => Values.Queen,
                        "King" => Values.King,
                        _ => throw new InvalidDataException($"Unrecognized card value: {cardParts[1]}"),
                    };

                    var suit = cardParts[2] switch
                    {
                        "Clubs" => Suits.Clubs,
                        "Diamonds" => Suits.Diamonds,
                        "Hearts" => Suits.Hearts,
                        "Spades" => Suits.Spades,
                        _ => throw new InvalidDataException($"Unrecognized card suit: {cardParts[2]}"),
                    };

                    Add(new Card(value, suit));
                }
            }
        }

        public void Reset()
        {
            Clear();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    Add(new Card((Values)value, (Suits)suit));
                }
            }
        }

        public Deck Shuffle()
        {
            List<Card> copy = new List<Card>(this);
            Clear();
            while (copy.Count > 0)
            {
                int index = random.Next(copy.Count);
                Card card = copy[index];
                copy.RemoveAt(index);
                Add(card);
            }
            return this;
        }

        public Card Deal(int index)
        {
            Card cardToDeal = base[index];
            RemoveAt(index);
            return cardToDeal;
        }

        public void WriteCards(string fileName)
        {
            using(StreamWriter sw = new StreamWriter(fileName))
            {
                foreach(Card card in this)
                {
                    sw.WriteLine(card.Name);
                }
            }
        }
    }
}
