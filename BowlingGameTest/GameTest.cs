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

            RollMany(20, 0);
            actual = g.Score();

            //�_�����
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        //���ժ��a��y20��,�C�����u�o�@���ɪ��`�o��
        //���浲�G��:20
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
