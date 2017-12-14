using System.Collections.Generic;
using System.Linq;

namespace SibalaTDD
{
    public class Dice
    {
        public List<int> _dices;

        public Dice(int[] dices)
        {
            this._dices = dices.ToList();
            InitializeByStates();
        }

        private void InitializeByStates()
        {
            GetDiceHandler().SetResult();
        }

        private IDiceHandler GetDiceHandler()
        {
            var diceHandlerLookup = new Dictionary<int, IDiceHandler>()
            {
                {1, new NoPointsHandler(this)},
                {2, new NormalPointsHandler(this)},
                {3, new NoPointsHandler(this)},
                {4, new SameColorHandler(this)},
            };
            return diceHandlerLookup[_dices.GroupBy(x => x).Max(x => x.Count())];
        }

        public int Points { get; set; }

        public int MaxPoint { get; set; }

        public DiceType Type { get; set; }

        public string Output { get; set; }
    }
}