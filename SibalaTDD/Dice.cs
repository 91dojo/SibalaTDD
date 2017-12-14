using System.Collections.Generic;
using System.Linq;

namespace SibalaTDD
{
    public class Dice
    {
        public List<int> _dices;
        private int _points;
        private int _maxPoint;
        private DiceType _diceType;
        private string _output;

        public Dice(int[] dices)
        {
            this._dices = dices.ToList();
            InitializeByStates();
        }

        private void InitializeByStates()
        {
            var maxCountOfSamePoints = _dices.GroupBy(x => x).Max(x => x.Count());

            GetDiceHandler(maxCountOfSamePoints).SetResult();
        }

        private IDiceHandler GetDiceHandler(int maxCountOfSamePoints)
        {
            if (maxCountOfSamePoints == 1 || maxCountOfSamePoints == 3)
            {
                return new NoPointsHandler(this);
            }
            else if (maxCountOfSamePoints == 4)
            {
                return new SameColorHandler(this);
            }

            return new NormalPointsHandler(this);
        }

        public int Points
        {
            get { return this._points; }
            set { this._points = value; }
        }

        public int MaxPoint
        {
            get { return this._maxPoint; }
            set { this._maxPoint = value; }
        }

        public DiceType Type
        {
            get { return this._diceType; }
            set { this._diceType = value; }
        }

        public string Output
        {
            get { return this._output; }
            set { this._output = value; }
        }
    }
}