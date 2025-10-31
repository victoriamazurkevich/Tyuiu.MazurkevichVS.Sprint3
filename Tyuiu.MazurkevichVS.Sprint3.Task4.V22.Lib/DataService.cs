﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MazurkevichVS.Sprint3.Task4.V22.Lib
{
    public class DataService : ISprint3Task4V22
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) continue;
                res *= (x / (Math.Sin(x) - x));
            }
            return Math.Round(res, 3);
        }
    }
}
