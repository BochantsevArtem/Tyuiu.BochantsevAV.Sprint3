using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BochantsevAV.Sprint3.Task7.V23.Lib
{
    public class DataService : ISprint3Task7V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            for (int i = 0; i < length; i++)
            {
                int x = startValue + i;
                double denominator = 2 * x - 2;

                if (denominator == 0)
                {
                    result[i] = 0;
                }
                else
                {
                    double y = 4 - 2 * x
                        + (2 + Math.Cos(x)) / denominator;

                    result[i] = Math.Round(y, 2);
                }
            }

            return result;
        }
    }
}
