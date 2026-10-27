using Tyuiu.BochantsevAV.Sprint3.Task1.V23.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task1.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title =
                "Спринт #3 | Выполнил: Бочанцев А.В | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил Бочанцев Артем Викторович | ИИПБ-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
            Console.WriteLine("* ряда по формуле, при х=5                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("* x = 5");
            Console.WriteLine("* Начальное значение k = 1");
            Console.WriteLine("* Конечное значение k = 5");

            int x = 5;
            int startValue = 1;
            int stopValue = 5;

            DataService ds = new DataService();
            double result = ds.GetMultiplySeries(x, startValue, stopValue);

            Console.WriteLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("* p = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
