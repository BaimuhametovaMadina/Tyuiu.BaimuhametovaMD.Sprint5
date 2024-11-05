using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task4.V26.Lib
{
    public class DataService: ISprint5Task4V26
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            text = text.Replace('.', ',');
            double x = double.Parse(text);
            Console.WriteLine(x);
            double f = (Math.Pow(x, 3) + Math.Sin(x))*Math.Cos(x);
            return Math.Round(f, 3);
        }
    }
}
