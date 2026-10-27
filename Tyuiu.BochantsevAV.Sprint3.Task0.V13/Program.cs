using Tyuiu.BochantsevAV.Sprint3.Task0.V13.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task0.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Бочанцев А.В | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил Бочанцев Артем Викторович | ИИПБ-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму          *");
            Console.WriteLine("* ряда по формуле, при a = 0,5                                            *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine();

          
            Console.WriteLine("* a = 0,5");
            Console.WriteLine("* Начальное значение k = 1");
            Console.WriteLine("* Конечное значение k = 20");
            Console.WriteLine();

            double a = 0.5;
            int startValue = 1;
            int stopValue = 20;

            DataService ds = new DataService();
            double result = ds.GetSumSeries(a, startValue, stopValue);

            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("* S = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
