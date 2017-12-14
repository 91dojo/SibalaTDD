using System.Linq;

namespace SibalaTDD
{
    public class SameColorHandler
    {
        private Dice _dice;

        public SameColorHandler(Dice dice)
        {
            _dice = dice;
        }

        public void SetResultWhenSameColor()
        {
            _dice.Points = _dice._dices.First();
            _dice.MaxPoint = _dice._dices.First();
            _dice.Type = DiceType.SameColor;
            _dice.Output = "same color";
        }
    }
}