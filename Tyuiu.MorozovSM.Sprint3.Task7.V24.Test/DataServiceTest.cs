using Tyuiu.MorozovSM.Sprint3.Task7.V24.Lib;

namespace Tyuiu.MorozovSM.Sprint3.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidGetMassFunction()
        {
            int startValue = -5;
            int endValue = 5;
            double[] valueArray = new double[endValue - startValue + 1];
            valueArray[0] = 7.83;
            valueArray[1] = 6.22;
            valueArray[2] = 6.36;
            valueArray[3] = 6.96;
            valueArray[4] = -0.52;
            valueArray[5] = 0;
            valueArray[6] = -3.3;
            valueArray[7] = -5.53;
            valueArray[8] = -6.25;
            valueArray[9] = -6.63;
            valueArray[10] = -8.24;
            CollectionAssert.AreEqual(valueArray, ds.GetMassFunction(startValue, endValue));
        }
    }
}