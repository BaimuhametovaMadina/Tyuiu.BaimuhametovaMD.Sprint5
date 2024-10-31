using Tyuiu.BaimuhametovaMD.Sprint5.Task2.V27.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3];
            Console.Title = "Спринт #5 | Выполнил: Баймухаметова М.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Баймухаметова Мадина | ИБКСб-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры. Заменить нечетные элементы         *");
            Console.WriteLine("* массива на 0. Результат сохранить в файл и вывести на консоль.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("Введите {0} строку матрицы через пробел: ", i + 1);
                string[] input = Console.ReadLine().Split(" ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToInt32(input[j]);
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] res = File.ReadAllText(ds.SaveToFileTextData(matrix)).Trim().Split(" ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(res[matrix.GetLength(j) * i + j + i]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
