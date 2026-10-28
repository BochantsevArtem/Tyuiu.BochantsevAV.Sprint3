using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BochantsevAV.Sprint3.Task2.V27.Lib
{
    public class DataService : ISprint3Task2V27
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;

            do
            {
                double term = 4.0 / (1 + Math.Pow(value, i));
                sum += Math.Pow(term, i);

                i++;
            }
            while (i <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}
