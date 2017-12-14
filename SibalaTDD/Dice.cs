using System.Collections.Generic;
using System.Linq;

namespace SibalaTDD
{
    public class Dice
    {
        private List<int> _dices;
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
            SetResultWhenSameColor();
        }

        private void SetResultWhenSameColor()
        {
            this._points = _dices.First();
            this._maxPoint = _dices.First();
            this._diceType = DiceType.SameColor;
            this._output = "same color";
        }

        public int Points
        {
            get { return this._points; }
        }

        public int MaxPoint
        {
            get { return this._maxPoint; }
        }

        public DiceType Type
        {
            get { return this._diceType; }
        }

        public string Output
        {
            get { return this._output; }
        }
    }
}