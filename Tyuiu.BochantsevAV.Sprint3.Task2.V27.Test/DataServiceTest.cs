using Tyuiu.BochantsevAV.Sprint3.Task2.V27.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double actual = ds.GetSumSeries(5, 1, 14);

            double expected = 0;

            int i = 1;

            do
            {
                double term = 4.0 / (1 + Math.Pow(5, i));
                expected += Math.Pow(term, i);
                i++;
            }
            while (i <= 14);

            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, actual, 0.01);
        }
    }
}
