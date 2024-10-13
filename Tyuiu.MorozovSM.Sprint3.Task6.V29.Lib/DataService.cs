using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MorozovSM.Sprint3.Task6.V29.Lib
{
    public class DataService : ISprint3Task6V29
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int del = 1; del <= i; del++)
                {
                    if (i % del == 0) sum += del;
                }
            }
            return sum;
        }
    }
}
