using System.Collections.Generic;

namespace SibalaTDD
{
    public class DiceComparer : IComparer<Dice>
    {
        public int Compare(Dice x, Dice y)
        {
            return IsSameType(x, y) ? GetComparer(x.Type).Compare(x, y) : CompareWhenDifferentType(x, y);
        }

        private static bool IsSameType(Dice x, Dice y)
        {
            return x.Type == y.Type;
        }

        private static int CompareWhenDifferentType(Dice x, Dice y)
        {
            return x.Type - y.Type;
        }

        private static IDiceComparer GetComparer(DiceType diceType)
        {
            var diceComparerLookup = new Dictionary<DiceType, IDiceComparer>()
            {
                {DiceType.SameColor, new SameColorDiceComparer()},
                {DiceType.NoPoints, new NoPointsDiceComparer()},
                {DiceType.NormalPoints, new NormalPointsDiceComparer()}
            };
            return diceComparerLookup[diceType];
        }
    }

    public interface IDiceComparer
    {
        int Compare(Dice x, Dice y);
    }
}