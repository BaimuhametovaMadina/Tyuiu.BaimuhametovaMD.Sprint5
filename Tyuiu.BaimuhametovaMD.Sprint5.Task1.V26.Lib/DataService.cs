using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task1.V26.Lib
{
    public class DataService: ISprint5Task1V26
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            double[] res = new double[11];
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            File.WriteAllText(path, "");
            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Cos(i) + i == 0) res[i + 5] = 0;
                else
                {
                    res[i + 5] = Math.Round((double)(2 * i + 6) / (Math.Cos(i) + i) - 3, 2);
                }
                File.AppendAllText(path, res[i+5].ToString() + "\n");
            }
            return path;
        }
    }
}
