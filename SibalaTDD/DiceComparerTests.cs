using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SibalaTDD
{
    [TestClass]
    public class DiceComparerTests
    {
        [TestMethod]
        public void NoPoints_1432_equal_to_6534()
        {
            var x = new Dice(new[] { 1, 4, 3, 2 });
            var y = new Dice(new[] { 6, 5, 3, 4 });

            var comparer = new DiceComparer();
            Assert.IsTrue(comparer.Compare(x, y) == 0);
        }
    }
}