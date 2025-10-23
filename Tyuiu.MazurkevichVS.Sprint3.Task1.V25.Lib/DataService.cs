using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MazurkevichVS.Sprint3.Task1.V25.Lib
{
    public class DataService : ISprint3Task1V25
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multseries = 1;
            while (startValue <= stopValue)
            {
                multseries *= ((Math.Pow(value, startValue) - 1/4) * Math.Cos(5));
                startValue++;
            }
            return Math.Round(multseries, 3);
        }
    }
}
