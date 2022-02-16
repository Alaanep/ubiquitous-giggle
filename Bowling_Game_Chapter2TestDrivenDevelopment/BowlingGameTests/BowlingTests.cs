using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling_Game_Chapter2TestDrivenDevelopment;

namespace BowlingGameTests
{
    [TestClass]
    public class BowlingTests
    {
        private Game game;

        [TestInitialize]
        public void Initialize() { game = new Game(); }



        [TestMethod]
        public void CanRoll()
        {
            game.Roll(0);
            Assert.AreEqual(0, game.Score());
        }

        [TestMethod]
        public void GutterGame()
        {

            rollMany(20, 0);
            Assert.AreEqual(0, game.Score());
        }

        [TestMethod]
        public void AllOnes()
        {
            rollMany(20, 1);
            Assert.AreEqual(20, game.Score()); ;
        }

        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                game.Roll(pins);

            }
        }

        [TestMethod]
        public void OneSpare()
        {
            rollSpare();
            game.Roll(7);
            rollMany(17, 0);
            Assert.AreEqual(24, game.Score());
        }

        [TestMethod]
        public void OneStrike()
        {
            rollStrike();
            game.Roll(2);
            game.Roll(3);
            rollMany(16, 0);
            Assert.AreEqual(20, game.Score());
        }

        [TestMethod]
        public void PerfectGame()
        {
            rollMany(12, 10);
            Assert.AreEqual(300, game.Score());
        }

        private void rollStrike()
        {
            game.Roll(10);
        }

        private void rollSpare()
        {
            rollMany(2, 5);
        }
    }
}