using Tyuiu.MorozovSM.Sprint3.Task5.V8.Lib;

namespace Tyuiu.MorozovSM.Sprint3.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.GetSumSumSeries(1, 1, 3, 12), 119.066);
        }
    }
}