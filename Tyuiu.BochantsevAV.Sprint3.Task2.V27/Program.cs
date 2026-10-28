using Tyuiu.BochantsevAV.Sprint3.Task2.V27.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title =
                "Спринт #3 | Выполнил: Бочанцев А.В | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил Бочанцев Артем Викторович | ИИПБ-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do-while, которая вычисляет           *");
            Console.WriteLine("* сумму ряда по формуле, при х=5                                          *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");

            Console.WriteLine("* x = 5");
            Console.WriteLine("* Начальное значение i = 1");
            Console.WriteLine("* Конечное значение i = 14");


            int x = 5;
            int startValue = 1;
            int stopValue = 14;

            DataService ds = new DataService();
            double result = ds.GetSumSeries(x, startValue, stopValue);

            Console.WriteLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("* S = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
