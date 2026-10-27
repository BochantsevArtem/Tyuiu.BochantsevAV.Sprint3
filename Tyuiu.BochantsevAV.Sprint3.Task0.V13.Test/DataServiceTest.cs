using Tyuiu.BochantsevAV.Sprint3.Task0.V13.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double a = 0.5;
            double expected = 0;

            for (int k = 1; k <= 20; k++)
            {
                expected += (Math.Pow(a, k) + 0.5) * Math.Cos(k);
            }

            double actual = ds.GetSumSeries(0.5, 1, 20);

            Assert.AreEqual(expected, actual, 0.1);
        }
    }
}
