using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task7.V18.Lib
{
    public class DataService: ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);
            text = text.Replace("н", "нн");
            string newpath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V18.txt");
            File.WriteAllText(newpath, text);
            return newpath;
        }
    }
}
