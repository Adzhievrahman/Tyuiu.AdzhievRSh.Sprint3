using System;
using Tyuiu.Adzhievrsh.Sprint3.Task3.V10.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Task #3 | Вариант 10";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Task #3                                                                 *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Используя цикл foreach удалить из строки все буквы p.         *");
            Console.WriteLine("***************************************************************************");

            string value = "gdfppf vfpppt p";

            Console.WriteLine("Исходная строка: " + value);

            DataService service = new DataService();

            string result = service.DeleteCharInString(value);

            Console.WriteLine();
            Console.WriteLine("Результат: " + result);

            Console.ReadKey();
        }
    }
}