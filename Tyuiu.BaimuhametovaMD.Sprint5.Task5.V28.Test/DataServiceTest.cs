using Tyuiu.BaimuhametovaMD.Sprint5.Task5.V28.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V28.txt");
            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(120, res);
        }
    }
}