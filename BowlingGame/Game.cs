using System;

namespace BowlingGame
{
    public class Game
    {
        private int totalScore;
        public void Roll(int pins)
        {
            totalScore += pins;
        }

        public int Score()
        {
            return totalScore;
        }
    }
}
