using Tyuiu.BaimuhametovaMD.Sprint5.Task2.V27.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint5.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReplacingValid()
        {
            DataService ds = new DataService();
            int[,] matrix =
            {
                {1, 4, 3 },
                {1, 1, 4 },
                {4, 3, 8 }
            };
            string wait = "0 4 0 0 0 4 4 0 8";
            string res = File.ReadAllText(ds.SaveToFileTextData(matrix)).Trim();
            Assert.AreEqual(wait, res);
        }
    }
}