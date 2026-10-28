using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BochantsevAV.Sprint3.Task6.V13.Lib
{
    public class DataService : ISprint3Task6V13
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int result = 0;

            for (int number = startValue; number <= stopValue; number++)
            {
                int sum = 0;

                for (int divisor = 1; divisor <= number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        sum += divisor;
                    }
                }

                if (sum > 8)
                {
                    result += sum;
                }
            }

            return result;
        }
    }
}
