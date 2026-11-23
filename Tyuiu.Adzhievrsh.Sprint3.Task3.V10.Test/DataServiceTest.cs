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
            DataService ds = new DataService();

            string value = "gdfppf vfppt p";
            string result = ds.DeleteCharInString(value);

            Assert.AreEqual("gdff vft ", result);
        }

        [TestMethod]
        public void ValidDeleteSelectedChar()
        {
            DataService ds = new DataService();

            string value = "hello world";
            string result = ds.DeleteCharInString(value, 'l');

            Assert.AreEqual("heo word", result);
        }
    }
}
