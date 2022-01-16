using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GoFish;

namespace GoFishTests
{
    [TestClass]
    public class GameStateTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            var computerPlayerNames = new List<string>()
            {
                "Computer1",
                "Computer2",
                "Computer3",
            };
            var gameState = new GameState("Human", computerPlayerNames, new Deck());

            CollectionAssert.AreEqual(new List<string> { "Human", "Computer1", "Computer2", "Computer3" },
                gameState.Players.Select(player=>player.Name).ToList());

            Assert.AreEqual(5, gameState.HumanPlayer.Hand.Count());
        }

        [TestMethod]
        public void TestRandomPlayer()
        {
            var computerPlayerNames = new List<string>() { "Computer1", "Computer2", "Computer3" };
            var gameState = new GameState("Human", computerPlayerNames, new Deck());
            Player.random = new MockRandom() { ValueToReturn = 1 };

            Assert.AreEqual("Computer2", gameState.RandomPlayer(gameState.Players.ToList()[0]).Name);

            Player.random = new MockRandom() { ValueToReturn = 0 };
            Assert.AreEqual("Human", gameState.RandomPlayer(gameState.Players.ToList()[1]).Name);
            Assert.AreEqual("Computer1", gameState.RandomPlayer(gameState.Players.ToList()[0]).Name);
        }

        [TestMethod]
        public void TestPlayRound()
        {
            var deck = new Deck();
            deck.Clear();
            var cardsToAdd = new List<Card>()
            {
                //cards the game will deal to Owen
                new Card(Values.Jack, Suits.Spades),
                new Card(Values.Jack, Suits.Hearts),
                new Card(Values.Six, Suits.Spades),
                new Card(Values.Jack, Suits.Diamonds),
                new Card(Values.Six, Suits.Hearts),

                //cards the game will deal to Brittany
                new Card(Values.Six, Suits.Diamonds),
                new Card(Values.Six, Suits.Clubs),
                new Card(Values.Seven, Suits.Spades),
                new Card(Values.Jack, Suits.Clubs),
                new Card(Values.Nine,  Suits.Spades),

                //two more cards in the deck for owen to draw when he runs out
                new Card(Values.Queen, Suits.Hearts),
                new Card(Values.King, Suits.Spades),
            };

            //set up the deck
            foreach (var card in cardsToAdd)
                deck.Add(card);

            var gamestate = new GameState("Owen", new List<string> { "Brittney" }, deck);
            Player owen = gamestate.HumanPlayer;
            Player brittney = gamestate.Opponents.First();

            //make sure gamestate was set up correctly
            Assert.AreEqual("Owen", owen.Name);
            Assert.AreEqual(5, owen.Hand.Count());
            Assert.AreEqual("Brittney", brittney.Name);
            Assert.AreEqual(5, brittney.Hand.Count());

            //in the first round owen asks brittney for jack. We set up the deck so that brittney has one jack
            var message = gamestate.PlayRound(owen, brittney, Values.Jack, deck);
            Assert.AreEqual("Owen asked Brittney for Jacks" + Environment.NewLine + "Brittney has 1 Jack card", message);
            Assert.AreEqual(1, owen.Books.Count());
            Assert.AreEqual(2, owen.Hand.Count());
            Assert.AreEqual(0, brittney.Books.Count());
            Assert.AreEqual(4, brittney.Hand.Count());


            //2nd round
            message = gamestate.PlayRound(brittney, owen, Values.Six, deck);
            Assert.AreEqual("Brittney asked Owen for Sixes" + Environment.NewLine + "Owen has 2 Six cards", message);
            Assert.AreEqual(1, owen.Books.Count());
            Assert.AreEqual(2, owen.Hand.Count());
            Assert.AreEqual(1, brittney.Books.Count());
            Assert.AreEqual(2, brittney.Hand.Count());

            //3rd round
            message = gamestate.PlayRound(owen, brittney, Values.Queen, deck);
            Assert.AreEqual("Owen asked Brittney for Queens" + Environment.NewLine + "The stock is out of cards", message);
            Assert.AreEqual(1, owen.Books.Count());
            Assert.AreEqual(2, owen.Hand.Count()); 
        }

        [TestMethod]
        public void TestCheckforWinner()
        {
            var computerPlayerNames = new List<string>()
            {
                "Computer1",
                "Computer2",
                "Computer3",
            };
            var emptyDeck = new Deck();
            emptyDeck.Clear();
            var gameState = new GameState("Human", computerPlayerNames, emptyDeck);
            Assert.AreEqual("The winners are Human and Computer1 and Computer2 and Computer3", gameState.CheckForWinner());
        }

    }
}
