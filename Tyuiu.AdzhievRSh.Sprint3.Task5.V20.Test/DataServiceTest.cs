using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AdzhievRSh.Sprint3.Task5.V20.Lib;

namespace Tyuiu.AdzhievRSh.Sprint3.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ReturnsExpectedSum()
        {
            DataService ds = new DataService();

            double res = ds.Calculate();

            double wait = 50584.322;

            Assert.AreEqual(wait, res);
        }
    }
}
