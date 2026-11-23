using System;
using Tyuiu.Adzhievrsh.Sprint3.Task4.V25.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task4.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Аджиев Р.Ш. | ИИПб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Аджиев Р.Ш. | ИИПб-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            DataService ds = new DataService();
            Console.WriteLine("Исходные данные: x от -5 до 5, остановка при x = 0");
            double result = ds.Calculate();

            Console.WriteLine($"Сумма значений функции = {result}");

            if (!Console.IsInputRedirected)
            {
                Console.ReadKey();
            }
        }
    }
}
