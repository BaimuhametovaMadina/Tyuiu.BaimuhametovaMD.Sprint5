using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task2.V27.Lib
{
    public class DataService: ISprint5Task2V27
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");
            File.WriteAllText(path, "");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0) matrix[i, j] = 0;
                    File.AppendAllText(path, matrix[i, j] + ", ");
                }
            }
            return path;
        }
    }
}
