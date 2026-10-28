using Tyuiu.BochantsevAV.Sprint3.Task3.V3.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title =
               "Спринт #3 | Выполнил: Бочанцев А.В | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил Бочанцев Артем Викторович | ИИПБ-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв f,        *");
            Console.WriteLine("*  находящихся на соседних позициях в строке: cvbmzff orffgtrr dkfvfffdr  *");
            Console.WriteLine("***************************************************************************");

            string text = "cvbmzfforffgtrr dklfvfffdr";

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("* Строка: " + text);

            DataService ds = new DataService();
            int result = ds.GetMinCharCount(text, 'f');

            Console.WriteLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("* Минимальное количество букв f = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
