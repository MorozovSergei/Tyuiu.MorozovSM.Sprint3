using Tyuiu.MorozovSM.Sprint3.Task3.V14.Lib;

namespace Tyuiu.MorozovSM.Sprint3.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Морозов С. М. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Морозов Сергей Максимович | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы d  на ’ в строке: dgt ghedd bed   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            char replaceable = 'd';
            char replacement = '’';
            string value = "dgt ghedd bed";
            string wait = "’gt ghe’’ be’";
            Console.WriteLine("Исходная строка " + value);
            Console.WriteLine("Символ который заменяем " + replaceable);
            Console.WriteLine("Символ на который заменяем " + replaceable);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.ReplaceCharInString(value, replaceable,replacement);
            Console.WriteLine("Получившаяся строка " + res);
            Console.ReadKey();
        }
    }
}
