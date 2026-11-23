using System;
using Tyuiu.Adzhievrsh.Sprint3.Task5.V20.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task5.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Аджиев Р.Ш. | ИИПб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Аджиев Р.Ш. | ИИПб-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            DataService ds = new DataService();

            Console.WriteLine("Исходные данные: x = 5, i от 1 до 3, k от 1 до 6");
            double result = ds.Calculate();

            Console.WriteLine($"Результат вычисления y = {result}");

            if (!Console.IsInputRedirected)
            {
                Console.ReadKey();
            }
        }
    }
}
