﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MazurkevichVS.Sprint3.Task7.V2.Lib
{
    public class DataService : ISprint3Task7V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] ValueArray;
            int len = (stopValue - startValue) + 1;
            ValueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Cos(x) / (x - 0.7)) - Math.Sin(x) * 12 * x + 2, 2);
                ValueArray[count] = y;
                count++;
            }
            return ValueArray;
        }

    }
}
