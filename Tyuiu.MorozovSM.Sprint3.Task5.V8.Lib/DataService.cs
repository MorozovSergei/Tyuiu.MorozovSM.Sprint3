using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MorozovSM.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    res += ((1 / Math.Sin(k)) + 3);
                }
            }
            return Math.Round(res,3);
        }
    }
}
