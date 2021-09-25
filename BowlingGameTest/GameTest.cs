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

        [TestMethod]
        //���ժ��a�㧽�u���@���ɤ�+�@���p���檺����
        //�@20����y���|,��l17����0��
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
        //���ժ��a�㧽�u���@������+�@���p���檺����
        //�@19����y���|,��l16����0��
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
        //���ժ��a�b�ҥH���˪�12��y���`�o����(����300��)
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
