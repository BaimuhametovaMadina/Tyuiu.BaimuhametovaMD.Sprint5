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
            Assert.AreEqual("���������� ����� � ��������� ���������� ��", File.ReadAllText(newpath));
        }
    }
}