using Tyuiu.BaimuhametovaMD.Sprint5.Task1.V26.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            int start = -5, stop = 5;
            string res = ds.SaveToFileTextData(start, stop);
            Assert.AreEqual(Convert.ToString(2), File.ReadAllText(res));
        }
    }
}