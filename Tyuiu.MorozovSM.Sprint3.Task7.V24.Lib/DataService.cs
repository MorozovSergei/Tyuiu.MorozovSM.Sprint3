using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MorozovSM.Sprint3.Task7.V24.Lib
{
    public class DataService : ISprint3Task7V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[stopValue-startValue+1];
            double f;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) { valueArray[count++] = 0; continue; }
                f = (Math.Sin(x)/(x+1.2)) - Math.Sin(x) * 2 - 2 * x;
                valueArray[count++] = Math.Round(f,2);
            }
            return valueArray;
        }
    }
}
