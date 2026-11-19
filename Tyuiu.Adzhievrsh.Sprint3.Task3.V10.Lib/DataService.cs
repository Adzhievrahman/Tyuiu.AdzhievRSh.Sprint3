using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;
using tyuiu.courses.programming.interfaces.Sprint3;

namespace Tyuiu.AdzhievRSh.Sprint3.Task3.V10.Lib
{
    public class DataService : ISprint3Task3V10
    {
        public string DeleteCharInString(string value)
        {
            StringBuilder result = new StringBuilder();

            foreach (char item in value)
            {
                if (item != 'p')
                {
                    result.Append(item);
                }
            }

            return result.ToString();
        }

        public string DeleteCharInString(string value, char item)
        {
            StringBuilder result = new StringBuilder();

            foreach (char symbol in value)
            {
                if (symbol != item)
                {
                    result.Append(symbol);
                }
            }

            return result.ToString();
        }
    }
}