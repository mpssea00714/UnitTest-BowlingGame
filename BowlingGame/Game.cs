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
                if (IsSpare(frameIndex))
                {
                    totalScore += 10 + rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    totalScore += rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return totalScore;
        }

        private bool IsSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }
    }
}
