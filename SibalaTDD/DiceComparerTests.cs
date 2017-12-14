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

        [TestMethod]
        public void SameColor_1111_should_larger_than_4444()
        {
            FirstShouldBeLargerThanSecond(new Dice(new[] { 1, 1, 1, 1 }), new Dice(new[] { 4, 4, 4, 4 }));
        }

        [TestMethod]
        public void SameColor_6666_should_smaller_than_4444()
        {
            FirstShouldBeSmallerThanSecond(new Dice(new[] { 6, 6, 6, 6 }), new Dice(new[] { 4, 4, 4, 4 }));
        }

        [TestMethod]
        public void NormalPoints_different_points_6632_smaller_2254()
        {
            FirstShouldBeSmallerThanSecond(new Dice(new[] { 6, 6, 3, 2 }), new Dice(new[] { 2, 2, 5, 4 }));
        }

        [TestMethod]
        public void NormalPoints_same_points_different_maxPoint_6632_smaller_2214()
        {
            FirstShouldBeSmallerThanSecond(new Dice(new[] { 6, 6, 3, 2 }), new Dice(new[] { 2, 2, 1, 4 }));
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