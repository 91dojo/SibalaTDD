using System.Collections.Generic;

namespace SibalaTDD
{
    public class DiceComparer : IComparer<Dice>
    {
        public int Compare(Dice x, Dice y)
        {
            if (x.Type != y.Type)
            {
                return x.Type - y.Type;
            }
            else
            {
                if (x.Type == DiceType.SameColor)
                {
                    return CompareWhenSameColor(x, y);
                }
                if (x.Type == DiceType.NormalPoints)
                {
                    return CompareWhenNormalPoints(x, y);
                }
                return CompareWhenNoPoints();
            }
        }

        private static int CompareWhenNoPoints()
        {
            return 0;
        }

        private static int CompareWhenSameColor(Dice x, Dice y)
        {
            var sameColorWeightLookup = new Dictionary<int, int>()
            {
                {1, 6},
                {4, 5},
                {6, 4},
                {5, 3},
                {3, 2},
                {2, 1},
            };
            return sameColorWeightLookup[x.Points] - sameColorWeightLookup[y.Points];
        }

        private static int CompareWhenNormalPoints(Dice x, Dice y)
        {
            if (x.Points == y.Points)
            {
                return x.MaxPoint - y.MaxPoint;
            }
            return x.Points - y.Points;
        }
    }
}