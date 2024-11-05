using Tyuiu.BaimuhametovaMD.Sprint5.Task6.V3.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SearchingValid()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V3.txt");
            Assert.AreEqual(21, ds.LoadFromDataFile(path));
        }
    }
}