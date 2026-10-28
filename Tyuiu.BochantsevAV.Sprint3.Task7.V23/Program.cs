using Tyuiu.BochantsevAV.Sprint3.Task7.V23.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task7.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Бочанцев А.В. | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Бочанцев Артем Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значения функции на отрезке [-5; 5] с шагом 1.                *");
            Console.WriteLine("* При делении на ноль вернуть 0. Округлить до двух знаков.                *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            Console.WriteLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine();

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"* x = {i - 5,3}: F(x) = {result[i],8:F2}");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
