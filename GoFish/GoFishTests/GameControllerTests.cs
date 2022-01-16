using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish;
namespace GoFishTests
{
    [TestClass]
    public class GameControllerTests
    {   
        [TestInitialize]
        public void Initialize()
        {
            Player.random = new MockRandom() { ValueToReturn = 0 };
        }

        /// <summary>
        /// Constructor test checks to make sure the status property is updated correctly
        /// after the GameController is instantiated
        /// </summary>
        [TestMethod]
        public void TestConstructor()
        {
            var gameController = new GameController("Human", new List<string>(){ "Player1", "Player2", "Player3" });
            Assert.AreEqual("Starting a new game with players Human, Player1, Player2, Player3", gameController.Status);
        }

        /// <summary>
        /// The NextRound method uses the Gamestate.randomPlayer and Player.RandomValueFromHand methods
        /// to make the computer players choose a random value to ask for and a player to ask,
        /// so we'll use MockRandom to test it
        /// </summary>
        [TestMethod]
        public void TestNextRound()
        {
            //constructor  shuffles the deck, but MockRandom makes sure it stays in order
            //so Owen should have Ace to 5 of Diamonds and Brittney should have 6 to 10 of Diamonds
            var gameController = new GameController("Owen", new List<string>() { "Brittney" });
            gameController.NextRound(gameController.Opponents.First(), Values.Six);
            Assert.AreEqual("Owen asked Brittney for Sixes" +
                Environment.NewLine + "Brittney has 1 Six card" +
                Environment.NewLine + "Brittney asked Owen for Sevens" +
                Environment.NewLine + "Brittney drew a card" +
                Environment.NewLine + "Owen has 6 cards and 0 books" +
                Environment.NewLine + "Brittney has 5 cards and 0 books" +
                Environment.NewLine + "The stock has 41 cards" +
                Environment.NewLine, gameController.Status);
        }

        /// <summary>
        /// Starting a new game causes GameController to create new  GameState with a newly
        /// shuffled deck (which will actually be in order because we are using MockRandom
        /// </summary>
        [TestMethod]
        public void TestNewGame()
        {
            Player.random = new MockRandom() { ValueToReturn = 0 };
            var gameController = new GameController("Owen",new List<string>(){"Brittney"});
            gameController.NextRound(gameController.Opponents.First(), Values.Six);
            gameController.NewGame();
            Assert.AreEqual("Owen", gameController.HumanPlayer.Name);
            Assert.AreEqual("Brittney", gameController.Opponents.First().Name);
            Assert.AreEqual("Starting a new game", gameController.Status);
        }
        

    }
}
