using System;
using System.Collections.Generic;

namespace Cards
{
    class Program
    {
        
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            //Card card = new Card((Values)random.Next(0, 3), (Suits)random.Next(1, 14));
            //Console.WriteLine(card.Name);
            //Deck deck = new Deck();
            //deck.PrintCards();
            List<Card> cards = new List<Card>();
            Console.Write("Enter number of cards: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfCards))
            {
                for(int i = 0; i < numberOfCards; i++)
                {
                    cards.Add(RandomCard());
                }
            }
            PrintCards(cards);
            cards.Sort(new CardComparer());
            Console.WriteLine("\n...sorting the cards ....\n");
            PrintCards(cards);
        }

         static Card RandomCard()
        {
            
            return new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
        }

        public static void PrintCards(List<Card> cards)
        {
            foreach(Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}
