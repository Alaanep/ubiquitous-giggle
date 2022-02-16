using System;
namespace Bowling_Game_Chapter2TestDrivenDevelopment
{
    public class Game
    {
        private int _score;
        private int[] rolls;
        private int currentRoll;

        public Game()
        {
            _score = 0;
            rolls = new int[21];
            currentRoll = 0;

        }

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int frameIndex = 0;
            for(int frame = 0; frame < 10; frame++)
            {
                if (isStrike(frameIndex))
                {
                    _score += strikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (isSpare(frameIndex))
                {
                    _score += 10 + spareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    _score += twoBallsInFrame(frameIndex);
                    frameIndex += 2;
                }
            }
            return _score;
        }

        private int twoBallsInFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }

        private int spareBonus(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }

        private int strikeBonus(int frameIndex)
        {
            return 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

        private bool isStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }

        private bool isSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }
    }
}
