using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MorozovSM.Sprint3.Task1.V20.Lib
{
    public class DataService : ISprint3Task1V20
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double SumlSeries = 0;

            while (startValue < stopValue + 1)
            {
                SumlSeries += Math.Pow(1/Math.Cos(startValue),2);
                startValue++;
            }
            return double.Round(SumlSeries, 3);
        }
    }
}
