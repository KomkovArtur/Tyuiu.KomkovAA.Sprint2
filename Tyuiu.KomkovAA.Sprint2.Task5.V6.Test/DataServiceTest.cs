using Tyuiu.KomkovAA.Sprint2.Task5.V6.Lib;
namespace Tyuiu.KomkovAA.Sprint2.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("туз пик", ds.FindCardNameAndValue(1, 14));
        }
    }
}
