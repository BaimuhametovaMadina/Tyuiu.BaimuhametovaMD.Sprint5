using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task5.V28.Lib
{
    public class DataService: ISprint5Task5V28
    {
        public double LoadFromDataFile(string path)
        {
            string[] text = File.ReadAllText(path).Replace('.', ',').Split(' ');
            double[] nums = new double[text.Length];
            double min = Double.MaxValue;
            for (int i = 0; i < text.Length; i++)
            {
                nums[i] = double.Parse(text[i]);
                if (nums[i] < min && nums[i] % 5 == 0 && nums[i] > 0) min = nums[i];
            }
            double res = 1;
            for (int i = (int)min; i > 0; i--)
            {
                res *= i;
            }
            return res;
        }
    }
}
