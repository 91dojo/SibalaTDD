using System.Collections.Generic;
using System.Linq;

namespace SibalaTDD
{
    public class NormalPointsHandler : IDiceHandler
    {
        private Dice _dice;

        public NormalPointsHandler(Dice dice)
        {
            _dice = dice;
        }

        public void SetResult()
        {
            var points = this.GetNormalPointsDices();

            _dice.Type = DiceType.NormalPoints;
            _dice.Points = points.Sum();
            _dice.MaxPoint = points.Max();
            _dice.Output = this.GetOutput();
        }

        private string GetOutput()
        {
            Dictionary<int, string> specialOutput = new Dictionary<int, string>()
            {
                {3,"BG" },
                {12,"Sibala" },
            };
            return IsSpecialOutput(specialOutput) ? specialOutput[_dice.Points] : $"{_dice.Points} points";
        }

        private bool IsSpecialOutput(Dictionary<int, string> specialOutput)
        {
            return specialOutput.ContainsKey(_dice.Points);
        }

        private IEnumerable<int> GetNormalPointsDices()
        {
            var ignorePoint = _dice._dices.GroupBy(x => x)
                .Where(x => x.Count() == 2)
                .Min(x => x.Key);

            return _dice._dices.Where(x => x != ignorePoint);
        }
    }
}