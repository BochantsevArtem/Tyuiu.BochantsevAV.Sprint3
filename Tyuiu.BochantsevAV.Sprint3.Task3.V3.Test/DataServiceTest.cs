using Tyuiu.BochantsevAV.Sprint3.Task3.V3.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string text = "cvbmzfforffgtrr dklfvfffdr";

            int actual = ds.GetMinCharCount(text, 'f');

            Assert.AreEqual(2, actual);
        }

        public void StringWithoutAdjacentF()
        {
            DataService ds = new DataService();

            int actual = ds.GetMinCharCount("abcdfg", 'f');

            Assert.AreEqual(0, actual);
        }
    }
}