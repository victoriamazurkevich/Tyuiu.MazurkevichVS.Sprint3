using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MazurkevichVS.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multseries = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                multseries *= Math.Pow((double)value / i, 3);
            }
            return Math.Round(multseries, 3);
        }
    }
}
