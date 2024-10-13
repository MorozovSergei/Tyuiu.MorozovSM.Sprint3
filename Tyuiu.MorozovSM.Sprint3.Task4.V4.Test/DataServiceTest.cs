using Tyuiu.MorozovSM.Sprint3.Task4.V4.Lib;

namespace Tyuiu.MorozovSM.Sprint3.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidCalculate()
        {
            Assert.AreEqual(ds.Calculate(-5, 5), 0);
        }
    }
}