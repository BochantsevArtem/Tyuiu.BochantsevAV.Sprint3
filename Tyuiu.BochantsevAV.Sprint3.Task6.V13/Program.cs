using Tyuiu.BochantsevAV.Sprint3.Task6.V13.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title =
                "Спринт #3 | Выполнил: Бочанцев А.В | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил Бочанцев Артем Викторович | ИИПБ-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("*  отрезку [8, 17] числа, сумма делителей которых больше 8.               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("* Начало отрезка = 8");
            Console.WriteLine("* Конец отрезка = 17");
            Console.WriteLine("* Условие: сумма делителей > 8");

            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(8, 17);


            Console.WriteLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("* " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
