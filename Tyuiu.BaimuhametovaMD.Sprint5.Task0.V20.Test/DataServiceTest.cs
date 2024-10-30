using Tyuiu.BaimuhametovaMD.Sprint5.Task0.V20.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            var res = ds.SaveToFileTextData(2);
            Assert.AreEqual(File.ReadAllText(res), (37.56).ToString());
        }
    }
}