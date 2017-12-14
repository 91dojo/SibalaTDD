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

            if (maxCountOfSamePoints == 1 || maxCountOfSamePoints == 3)
            {
                new NoPointsHandler(this).SetResultWhenNoPoints();
                return;
            }
            else if (maxCountOfSamePoints == 4)
            {
                new SameColorHandler(this).SetResultWhenSameColor();
                return;
            }

            SetResultWhenNormalPoints();
        }

        private void SetResultWhenNormalPoints()
        {
            var points = GetNormalPointsDices();

            this._diceType = DiceType.NormalPoints;
            this._points = points.Sum();
            this._maxPoint = points.Max();
            this._output = GetOutput();
        }

        private string GetOutput()
        {
            Dictionary<int, string> specialOutput = new Dictionary<int, string>()
            {
                {3,"BG" },
                {12,"Sibala" },
            };
            return IsSpecialOutput(specialOutput) ? specialOutput[_points] : $"{this._points} points";
        }

        private bool IsSpecialOutput(Dictionary<int, string> specialOutput)
        {
            return specialOutput.ContainsKey(_points);
        }

        private IEnumerable<int> GetNormalPointsDices()
        {
            var ignorePoint = _dices.GroupBy(x => x)
                .Where(x => x.Count() == 2)
                .Min(x => x.Key);

            return _dices.Where(x => x != ignorePoint);
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