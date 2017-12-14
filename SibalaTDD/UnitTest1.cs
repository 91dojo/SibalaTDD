using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SibalaTDD
{
    [TestClass]
    public class DiceTests
    {
        private Dice _dice;

        [TestMethod]
        public void sameColor()
        {
            _dice = new Dice(new int[] { 2, 2, 2, 2 });
            PointsShouldBe(2);
            MaxPointShouldBe(2);
            TypeShouldBe(DiceType.SameColor);
            OutputShouldBe("same color");
        }

        [TestMethod]
        public void noPoints_2563()
        {
            _dice = new Dice(new int[] { 2, 5, 6, 3 });
            PointsShouldBe(0);
            MaxPointShouldBe(0);
            TypeShouldBe(DiceType.NoPoints);
            OutputShouldBe("no points");
        }

        [TestMethod]
        public void noPoints_4442_3DicesWithSamePoint()
        {
            _dice = new Dice(new int[] { 4, 4, 4, 2 });
            PointsShouldBe(0);
            MaxPointShouldBe(0);
            TypeShouldBe(DiceType.NoPoints);
            OutputShouldBe("no points");
        }

        [TestMethod]
        public void normalPoints_5542_1pair()
        {
            _dice = new Dice(new int[] { 5, 5, 4, 2 });
            PointsShouldBe(6);
            MaxPointShouldBe(4);
            TypeShouldBe(DiceType.NormalPoints);
            OutputShouldBe("6 points");
        }

        private void OutputShouldBe(string expected)
        {
            Assert.AreEqual(expected, _dice.Output);
        }

        private void TypeShouldBe(DiceType expected)
        {
            Assert.AreEqual(expected, _dice.Type);
        }

        private void MaxPointShouldBe(int expected)
        {
            Assert.AreEqual(expected, _dice.MaxPoint);
        }

        private void PointsShouldBe(int expected)
        {
            Assert.AreEqual(expected, _dice.Points);
        }
    }
}