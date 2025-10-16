using Tyuiu.KomkovAA.Sprint2.Task2.V16.Lib;
namespace Tyuiu.KomkovAA.Sprint2.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();

            int x = 4;
            int y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
