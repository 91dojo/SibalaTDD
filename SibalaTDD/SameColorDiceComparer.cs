using System.Collections.Generic;

namespace SibalaTDD
{
    public class SameColorDiceComparer
    {
        public  int Compare(Dice x, Dice y)
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
    }
}