using System;

namespace BowlingGame
{
    public class Game
    {
        private int[] rolls = new int[20];
        private int currentRoll = 0;


        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int totalScore = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsSrike(frameIndex))
                {
                    totalScore += StrikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (IsSpare(frameIndex))
                {
                    totalScore += 10 + SpareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    totalScore += SumOfBallsInFrame(frameIndex);
                    frameIndex += 2;
                }
            }
            return totalScore;
        }

        private int SumOfBallsInFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }

        private int SpareBonus(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }

        private int StrikeBonus(int frameIndex)
        {
            return 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

        private bool IsSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        private bool IsSrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }
    }
}
