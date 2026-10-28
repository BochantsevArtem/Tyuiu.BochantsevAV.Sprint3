using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BochantsevAV.Sprint3.Task4.V10.Lib
{
    public class DataService : ISprint3Task4V10
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 1.0;
            int x = startValue;

            while (x <= stopValue)
            {
                if (x != 0)
                {
                    double y = (Math.Sin(x) - x) / x;
                    result *= y;
                }

                x++;
            }

            return Math.Round(result, 3);
        }
    }
}
