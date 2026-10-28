using Tyuiu.BochantsevAV.Sprint3.Task5.V21.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double expected = 0;

            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 10; k++)
                {
                    expected += Math.Pow(2, 3) * Math.Cos(k);
                }
            }

            expected += 2;
            expected = Math.Round(expected, 3);

            double actual = ds.GetSumSumSeries(2, 1, 1, 3, 10);

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
