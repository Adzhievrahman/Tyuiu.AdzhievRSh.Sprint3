using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AdzhievRSh.Sprint3.Task5.V20.Lib
{
    public class DataService : ISprint3Task5V20
    {
        public double Calculate()
        {
            return GetSumSumSeries(5, 1, 1, 3, 6);
        }

        double ISprint3Task5V20.GetSumSumSeries(
            int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            return GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
        }

        private static double GetSumSumSeries(
            int x,
            int startValue1,
            int startValue2,
            int stopValue1,
            int stopValue2)
        {
            double sumSeries = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sumSeries += Math.Pow((double)x / Math.Sin(x), k);
                }
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
