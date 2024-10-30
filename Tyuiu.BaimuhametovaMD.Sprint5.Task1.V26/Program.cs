using Tyuiu.BaimuhametovaMD.Sprint5.Task1.V26.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task1.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int start = -5, end = 5;
            Console.Title = "Спринт #4 | Выполнил: Баймухаметова М.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Баймухаметова Мадина | ИБКСб-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение, вычислить его значение при x = 2,                       *");
            Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt                *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 2.12x^3 + 1.05x^2 + 4.1x * 2, x=2                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(start, end);

            string[] res = File.ReadAllText(path).Trim().Split("\n");
            Console.WriteLine("+--------+--------+\n" +
                              "|   x    |  f(x)  |\n" +
                              "+--------+--------+");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine("|{0,8:d}|{1,8:f2}|", (i - 5), res[i]);
                Console.WriteLine("+--------+--------+");
            }

            Console.ReadLine();
        }
    }
}
