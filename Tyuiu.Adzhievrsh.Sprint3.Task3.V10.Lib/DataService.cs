using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.Adzhievrsh.Sprint3.Task3.V10.Lib
{
    public class DataService : ISprint3Task3V10
    {
        public string DeleteCharInString(string value)
        {
            return DeleteCharInString(value, 'p');
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