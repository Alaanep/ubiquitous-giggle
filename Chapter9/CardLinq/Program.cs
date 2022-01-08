using System;
using System.Linq;

namespace CardLinq
{
    class Program
    {
        static string Output(Suits suit, int number) => $"Suit is {suit} and number is {number}";

        static void Main(string[] args)
        {
            //var deck = new Deck().Shuffle().Take(16);
            //IOrderedEnumerable<IGrouping<Suits, Card>> grouped =
            //    from card in deck
            //    group card by card.Suit into suitGroup
            //    orderby suitGroup.Key descending
            //    select suitGroup;

            //foreach(var group in grouped)
            //{
            //    yes(group);
            //}

            var deck = new Deck();
            var processedCards = deck
                .Take(3)
                .Concat(deck.TakeLast(3))
                .OrderByDescending(card => card)
                .Select(card => card.Value switch
                {
                    Values.King => Output(card.Suit, 7),
                    Values.Ace => $"It's an ace! {card.Suit}",
                    Values.Jack => Output((Suits)card.Suit - 1, 9),
                    Values.Two => Output((Suits)card.Suit, 18),
                    _ => card.ToString(),

                });

            //var processedCards = deck
            //    .Take(3)
            //    .Concat(deck.TakeLast(3))
            //    .OrderByDescending(card => card);
                

            foreach (var output in processedCards)
            {
                Console.WriteLine(output);
            }
        }

        //private static void yes(IGrouping<Suits, Card> group)
        //{
        //    Console.WriteLine($@" 
        //            Group: {group.Key}
        //            Count: {group.Count()}
        //            Minimum: {group.Min()}
        //            Maximum: {group.Max()}
        //        ");
        //}
    }
}
