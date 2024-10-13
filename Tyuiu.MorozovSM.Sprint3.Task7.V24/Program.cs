using Tyuiu.MorozovSM.Sprint3.Task7.V24.Lib;

namespace Tyuiu.MorozovSM.Sprint3.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Морозов С. М. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Морозов Сергей Максимович | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит значение функции                    *");
            Console.WriteLine("* ряда по формуле, при a=0,25                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("+-----------+------------+");
            Console.WriteLine("|     X     |    F(x)    |");
            Console.WriteLine("+-----------+------------+");
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("|{0,6:d}     |   {1,5:f2}    |", startValue, res[i]);
                startValue++;
            }
            Console.WriteLine("+-----------+------------+");
            Console.ReadKey();
        }
    }
}
