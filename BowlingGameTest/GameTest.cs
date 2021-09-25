using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTest
{
    [TestClass]
    public class GameTest
    {
        private Game g;

        [TestInitialize]
        public void Setup()
        {
            g = new Game();
        }

        [TestMethod]
        public void TestGutterGame()
        {
            int expected = 0; //期望結果值
            int actual;       //實際結果值

            RollMany(20, 0);
            actual = g.Score();

            //斷言比對
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        //測試玩家投球20次,每次都只得一分時的總得分
        //期望結果值:20
        public void TestAllOnes()
        {
            int expected = 20;
            int actual;

            RollMany(20, 1);
            actual = g.Score();

            Assert.AreEqual(actual, expected);
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                g.Roll(pins);
            }
        }
    }
}
