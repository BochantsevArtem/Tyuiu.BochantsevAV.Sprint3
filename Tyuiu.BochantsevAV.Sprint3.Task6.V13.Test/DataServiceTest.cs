using Tyuiu.BochantsevAV.Sprint3.Task6.V13.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int expected = 117;
            int actual = ds.GetSumTheDivisors(8, 17);

            Assert.AreEqual(expected, actual);
        }
    }
}
