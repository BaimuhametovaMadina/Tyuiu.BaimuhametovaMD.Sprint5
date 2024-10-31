using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task3.V7.Lib
{
    public class DataService: ISprint5Task3V7
    {
        public string SaveToFileTextData(int x)
        {
            double f = 1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x;
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));
            writer.Write(f);
            writer.Close();
            return path;
        }
    }
}
