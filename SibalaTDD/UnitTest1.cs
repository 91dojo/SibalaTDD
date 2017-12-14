using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SibalaTDD
{
    [TestClass]
    public class DiceTests
    {
        [TestMethod]
        public void sameColor()
        {
            Dice dice = new Dice(new int[] { 2, 2, 2, 2 });
            Assert.AreEqual(2, dice.Points);
            Assert.AreEqual(2, dice.MaxPoint);
            Assert.AreEqual(DiceType.SameColor, dice.Type);
            Assert.AreEqual("same color", dice.Output);
        }
    }
}