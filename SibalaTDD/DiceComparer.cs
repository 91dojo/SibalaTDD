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
                    var sameColorWeightLookup = new Dictionary<int, int>()
                    {
                        {1,6 },
                        {4,5 },
                        {6,4 },
                        {5,3 },
                        {3,2 },
                        {2,1 },
                    };
                    return sameColorWeightLookup[x.Points] - sameColorWeightLookup[y.Points];
                }
                return 0;
            }
        }
    }
}