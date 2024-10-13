using Tyuiu.MorozovSM.Sprint3.Task4.V4.Lib;

namespace Tyuiu.MorozovSM.Sprint3.Task4.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Морозов С. М. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Морозов Сергей Максимович | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=x/(cos(x)+sin(x)) При х = 0 прервать цикл.                    *");
            Console.WriteLine("* Полученные значения суммировать.                                        *");
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
            var res = ds.Calculate(startValue, stopValue);
            Console.WriteLine("Сумма ряда = " + res);
            Console.ReadKey();
        }
    }
}
