namespace SibalaTDD
{
    public class NoPointsHandler
    {
        private Dice _dice;

        public NoPointsHandler(Dice dice)
        {
            _dice = dice;
        }

        public void SetResultWhenNoPoints()
        {
            _dice.Points = 0;
            _dice.MaxPoint = 0;
            _dice.Type = DiceType.NoPoints;
            _dice.Output = "no points";
        }
    }
}