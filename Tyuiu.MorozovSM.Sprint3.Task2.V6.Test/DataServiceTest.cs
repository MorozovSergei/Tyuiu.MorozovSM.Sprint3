using Tyuiu.MorozovSM.Sprint3.Task2.V6.Lib;

namespace Tyuiu.MorozovSM.Sprint3.Task2.V6.Test
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
            int stopValue = 10;
            var res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(0, res);

        }
    }
}