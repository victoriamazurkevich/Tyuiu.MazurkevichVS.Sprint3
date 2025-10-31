﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MazurkevichVS.Sprint3.Task3.V21.Lib
{
    public class DataService : ISprint3Task3V21
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    value = value.Replace(c, 'e');
                }
            }
            return value;
        }
    }
}
