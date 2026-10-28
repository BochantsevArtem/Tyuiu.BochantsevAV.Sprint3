using Tyuiu.BochantsevAV.Sprint3.Task4.V10.Lib;
namespace Tyuiu.BochantsevAV.Sprint3.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double expected = 1.0;

            for (int x = -5; x <= 5; x++)
            {
                if (x != 0)
                {
                    double y = (Math.Sin(x) - x) / x;
                    expected *= y;
                }
            }

            expected = Math.Round(expected, 3);

            double actual = ds.Calculate(-5, 5);

            Assert.AreEqual(expected, actual, 0.01);
        }

        public void TestMethod2()
        {
            DataService ds = new DataService();

            double actual = ds.Calculate(-1, 1);

            double expected = Math.Round(
                ((Math.Sin(-1) - (-1)) / -1) *
                ((Math.Sin(1) - 1) / 1), 3);

            Assert.AreEqual(expected, actual, 0.01);

        }



    
        
    }
}
