using Tyuiu.BochantsevAV.Sprint3.Task1.V23.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double expected = 1.0;

            for (int k = 1; k <= 5; k++)
            {
                expected *= Math.Pow(
                    300.0 / (Math.Sin(5.0) + Math.Pow(5.0, k)), k);
            }

            double actual = ds.GetMultiplySeries(5, 1, 5);

            Assert.AreEqual(expected, actual, Math.Abs(expected) * 0.01);

        }
    }
}
