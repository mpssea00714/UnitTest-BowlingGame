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

        [TestMethod]
        //測試玩家整局只有一次補中+一次計分格的分數
        //共20次投球機會,其餘17次皆0分
        public void TsetOneSpare()
        {
            int expected = 16;
            int actual;

            RollSpare();
            g.Roll(3);
            RollMany(17, 0);

            actual = g.Score();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        //測試玩家整局只有一次全中+一次計分格的分數
        //共19次投球機會,其餘16次皆0分
        private void TestOneStrike()
        {
            int expected = 24;
            int actual;

            RollStrike();
            g.Roll(3);
            g.Roll(4);

            RollMany(16, 0);
            actual = g.Score();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        //測試玩家在所以全倒的12投球中總得分數(滿分300分)
        private void TestPerfectGame()
        {
            int expected = 300;
            int actual;

            RollMany(12, 10);
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

        private void RollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }
        private void RollStrike()
        {
            g.Roll(10);
        }
    }
}
