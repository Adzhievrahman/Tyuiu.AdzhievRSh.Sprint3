using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AdzhievRSh.Sprint3.Task3.V10.Lib;

namespace Tyuiu.AdzhievRSh.Sprint3.Task3.V10.Test
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
        public void ValidStringWithoutPIsUnchanged()
        {
            DataService ds = new DataService();

            string value = "hello world";
            string result = ds.DeleteCharInString(value);

            Assert.AreEqual(value, result);
        }
    }
}
