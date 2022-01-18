using System;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "deckofcards.text";
            Deck deck = new Deck();
            deck.Shuffle();
            for(int i = deck.Count-1; i > 10; i--)
            {
                deck.RemoveAt(i);
            }
            deck.WriteCards(fileName);

            Deck cardsToRead = new Deck(fileName);
            foreach(Card card in cardsToRead)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}
