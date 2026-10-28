using Tyuiu.BochantsevAV.Sprint3.Task4.V10.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task4.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title =
                "Спринт #3 | Выполнил: Бочанцев А.В | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил Бочанцев Артем Викторович | ИИПБ-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить произведение значений функции                                 *");
            Console.WriteLine("* y = (sin(x) - x) / x на отрезке от -5 до 5                              *");
            Console.WriteLine("* При x = 0 значение пропустить                                           *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("* Начальное значение x = -5");
            Console.WriteLine("* Конечное значение x = 5");

            DataService ds = new DataService();
            double result = ds.Calculate(-5, 5);

            Console.WriteLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("* Произведение = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
