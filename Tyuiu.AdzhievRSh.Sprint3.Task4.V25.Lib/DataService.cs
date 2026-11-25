using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AdzhievRSh.Sprint3.Task4.V25.Lib
{
    public class DataService : ISprint3Task4V25
    {
        public double Calculate()
        {
            return CalculateRange(-5, 5);
        }

        double ISprint3Task4V25.Calculate(int startValue, int stopValue)
        {
            return CalculateRange(startValue, stopValue);
        }

        private static double CalculateRange(int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }

                double y = x / (Math.Cos(x) - Math.Sin(x));
                sum += y;
            }

            return Math.Round(sum, 3);
        }
    }
}
