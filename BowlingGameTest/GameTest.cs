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
            int expected = 0; //���浲�G��
            int actual;       //��ڵ��G��

            for (int i = 0; i <20; i++)
            {
                g.Roll(0);
            }

            actual = g.Score();

            //�_�����
            Assert.AreEqual(actual, expected);
        }
    }
}
