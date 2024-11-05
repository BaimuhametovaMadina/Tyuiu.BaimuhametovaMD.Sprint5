using Tyuiu.BaimuhametovaMD.Sprint5.Task7.V18.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReplacingValid()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V18.txt");
            string newpath = ds.LoadDataAndSave(path);
            Assert.AreEqual("Словарнные слова с удвоенной согласнной нн", File.ReadAllText(newpath));
        }
    }
}