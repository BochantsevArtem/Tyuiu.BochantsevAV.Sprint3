using Tyuiu.BochantsevAV.Sprint3.Task7.V23.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double[] actual = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, actual.Length);
            Assert.AreEqual(0.0, actual[6]); // x = 1
            Assert.AreEqual(13.81, actual[0]); // x = -5
        }
    }
}
