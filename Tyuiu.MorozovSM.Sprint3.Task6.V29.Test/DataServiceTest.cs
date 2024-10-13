using Tyuiu.MorozovSM.Sprint3.Task6.V29.Lib;

namespace Tyuiu.MorozovSM.Sprint3.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            int startValue = 12;
            int endValue = 18;
            Assert.AreEqual(ds.GetSumTheDivisors(startValue, endValue), 0);
        }
    }
}