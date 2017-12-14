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

        private static void FirstShouldBeEqualToSecond(Dice first, Dice second)
        {
            Assert.IsTrue(new DiceComparer().Compare(first, second) == 0);
        }
    }
}