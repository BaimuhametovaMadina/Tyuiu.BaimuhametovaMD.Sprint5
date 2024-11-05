using Tyuiu.BaimuhametovaMD.Sprint5.Task4.V26.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V26.txt");
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(52.842, res);
        }
    }
}