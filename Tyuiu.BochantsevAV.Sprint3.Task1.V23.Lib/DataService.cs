using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BochantsevAV.Sprint3.Task1.V23.Lib
{
    public class DataService : ISprint3Task1V23
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1.0;
            int k = startValue;

            while (k <= stopValue)
            {
                double denominator = Math.Sin(value) + Math.Pow(value, k);
                double term = 300.0 / denominator;

                result *= Math.Pow(term, k);
                k++;
            }

            return result;
        }
    }
}
