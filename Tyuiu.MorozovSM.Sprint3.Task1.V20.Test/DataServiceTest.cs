using Tyuiu.MorozovSM.Sprint3.Task1.V20.Lib;

namespace Tyuiu.MorozovSM.Sprint3.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            int startValue = 1;
            int stopValue = 16;
            var res = ds.GetSumSeries(startValue, stopValue);
            Assert.AreEqual(0, res);
        }
    }
}