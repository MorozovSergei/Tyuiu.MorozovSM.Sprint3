using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MorozovSM.Sprint3.Task0.V22.Lib
{
    public class DataService : ISprint3Task0V22
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double MulSeries = 1;
            for (int i = startValue; i < stopValue; i++)
            {
                MulSeries *= ((Math.Pow(value, i) + 4) * Math.Cos(value));
            }
            return double.Round(MulSeries, 3);
        }
    }
}