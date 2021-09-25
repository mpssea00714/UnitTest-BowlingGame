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

            for (int i = 0; i <20; i++)
            {
                g.Roll(0);
            }

            actual = g.Score();

            //斷言比對
            Assert.AreEqual(actual, expected);
        }
    }
}
