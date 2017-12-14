using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SibalaTDD
{
    [TestClass]
    public class DiceComparerTests
    {
        [TestMethod]
        public void NoPoints_1432_equal_to_6534()
        {
            FirstShouldBeEqualToSecond(new Dice(new[] { 1, 4, 3, 2 }), new Dice(new[] { 6, 5, 3, 4 }));
        }

        [TestMethod]
        public void NormalPoints_should_be_larger_than_NoPoints()
        {
            FirstShouldBeLargerThanSecond(new Dice(new[] { 2, 2, 4, 3 }), new Dice(new[] { 6, 5, 3, 4 }));
        }

        [TestMethod]
        public void NormalPoints_should_be_smaller_than_SameColor()
        {
            FirstShouldBeSmallerThanSecond(new Dice(new[] { 2, 2, 4, 3 }), new Dice(new[] { 2, 2, 2, 2 }));
        }

        private void FirstShouldBeSmallerThanSecond(Dice x, Dice y)
        {
            Assert.IsTrue(new DiceComparer().Compare(x, y) < 0);
        }

        private void FirstShouldBeLargerThanSecond(Dice x, Dice y)
        {
            Assert.IsTrue(new DiceComparer().Compare(x, y) > 0);
        }

        private static void FirstShouldBeEqualToSecond(Dice first, Dice second)
        {
            Assert.IsTrue(new DiceComparer().Compare(first, second) == 0);
        }
    }
}