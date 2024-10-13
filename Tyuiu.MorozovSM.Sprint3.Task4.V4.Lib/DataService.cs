using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MorozovSM.Sprint3.Task4.V4.Lib
{
    public class DataService : ISprint3Task4V4
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for(int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) break;
                res += (x / (Math.Cos(x) + Math.Sin(x)));
            }
            return double.Round(res,3);
        }
    }
}
