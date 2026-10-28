using Tyuiu.BochantsevAV.Sprint3.Task5.V21.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task5.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title =
                "Спринт #3 | Выполнил: Бочанцев А.В | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил Бочанцев Артем Викторович | ИИПБ-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму по формуле при x = 2                                    *");
            Console.WriteLine("* i от 1 до 3, k от 1 до 10                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("* x = 2");

            int x = 2;

            DataService ds = new DataService();
            double result = ds.GetSumSumSeries(x, 1, 1, 3, 10);

            Console.WriteLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("* y = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
