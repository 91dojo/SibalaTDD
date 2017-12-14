using System.Collections.Generic;

namespace SibalaTDD
{
    public class DiceComparer : IComparer<Dice>
    {
        public int Compare(Dice x, Dice y)
        {
            if (x.Type!= y.Type)
            {
                return x.Type - y.Type;
            }
            return 0;
        }
    }
}