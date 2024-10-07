using Tyuiu.MorozovSM.Sprint3.Task0.V22.Lib;

namespace Tyuiu.MorozovSM.Sprint3.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;
            var res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(0, res);
        }
    }
}