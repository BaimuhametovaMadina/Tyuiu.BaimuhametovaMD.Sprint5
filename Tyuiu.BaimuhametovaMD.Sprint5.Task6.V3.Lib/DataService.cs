using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task6.V3.Lib
{
    public class DataService: ISprint5Task6V3
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            char[] chars = text.ToCharArray();
            Regex reg = new Regex("[A-Za-z]");
            int count = text.Count(x => reg.IsMatch(x.ToString()));
        return count;
        }
    }
}
