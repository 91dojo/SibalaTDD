namespace SibalaTDD
{
    public class NormalPointsDiceComparer : IDiceComparer
    {
        public int Compare(Dice x, Dice y)
        {
            if (x.Points == y.Points)
            {
                return x.MaxPoint - y.MaxPoint;
            }
            return x.Points - y.Points;
        }
    }
}