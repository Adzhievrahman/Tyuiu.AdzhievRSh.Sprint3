using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint3.Task3.V10.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService service = new DataService();

            string value = "gdfppf vfpppt p";
            string result = service.DeleteCharInString(value);

            Assert.AreEqual("gdff vft ", result);
        }

        [TestMethod]
        public void ValidDeleteSelectedChar()
        {
            DataService service = new DataService();

            string value = "hello world";
            string result = service.DeleteCharInString(value, 'l');

            Assert.AreEqual("heo word", result);
        }
    }
}