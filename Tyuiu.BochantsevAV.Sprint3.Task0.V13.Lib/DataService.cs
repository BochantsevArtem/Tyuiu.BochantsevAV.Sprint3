using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BochantsevAV.Sprint3.Task0.V13.Lib
{
    public class DataService : ISprint3Task0V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)

        {
            double sum = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                sum += (Math.Pow(value, k) + 0.5) * Math.Cos(k);
            }

            return sum;

        }
    }
}