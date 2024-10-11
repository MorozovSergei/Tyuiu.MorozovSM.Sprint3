using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MorozovSM.Sprint3.Task2.V6.Lib
{
    public class DataService : ISprint3Task2V6
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double MulSeries = 1;
            for (int i = startValue; i < stopValue + 1; i++)
            {
                MulSeries *= ((Math.Pow(value, i) + 1) * Math.Cos(4));
            }
            return double.Round(MulSeries, 3);
        }
    }
}
