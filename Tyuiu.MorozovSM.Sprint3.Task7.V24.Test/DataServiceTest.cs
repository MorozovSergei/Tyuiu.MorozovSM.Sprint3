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
            valueArray[0] = 9.09;
            valueArray[1] = 7.5;
            valueArray[2] = 7.53;
            valueArray[3] = 7.47;
            valueArray[4] = 5.72;
            valueArray[5] = 0;
            valueArray[6] = -1.64;
            valueArray[7] = -4.16;
            valueArray[8] = -5.04;
            valueArray[9] = -5.48;
            valueArray[10] = -7.07;
            CollectionAssert.AreEqual(valueArray, ds.GetMassFunction(startValue, endValue));
        }
    }
}