using System;
using Tyuiu.AdzhievRSh.Sprint3.Task3.V10.Lib;

namespace Tyuiu.AdzhievRSh.Sprint3.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Аджиев Р.Ш. | ИИПб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Аджиев Р.Ш. | ИИПб-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            DataService ds = new DataService();

            string value = "gdfppf vfppt p";

            Console.WriteLine("Исходная строка: " + value);

            string result = ds.DeleteCharInString(value);

            Console.WriteLine("Результат: " + result);

            if (!Console.IsInputRedirected)
            {
                Console.ReadKey();
            }
        }
    }
}
