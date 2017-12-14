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