using Tyuiu.KomkovAA.Sprint2.Task6.V10.Lib;
namespace Tyuiu.KomkovAA.Sprint2.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("15.10.2025", ds.FindDateOfPreviousDay(2025, 10, 16));
        }
    }
}
