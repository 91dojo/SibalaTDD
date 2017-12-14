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
                    return new SameColorDiceComparer().CompareWhenSameColor(x, y);
                }
                if (x.Type == DiceType.NormalPoints)
                {
                    return CompareWhenNormalPoints(x, y);
                }
                return CompareWhenNoPoints(x, y);
            }
        }

        private static int CompareWhenNoPoints(Dice dice1, Dice dice)
        {
            return 0;
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