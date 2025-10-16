using Tyuiu.KomkovAA.Sprint2.Task4.V15.Lib;
namespace Tyuiu.KomkovAA.Sprint2.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double z = ds.Calculate(x, y);
            double wait = 3.5;
            Assert.AreEqual(wait, z);
        }
    }
}
