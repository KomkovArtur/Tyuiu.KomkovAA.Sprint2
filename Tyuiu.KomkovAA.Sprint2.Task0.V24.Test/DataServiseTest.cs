using Tyuiu.KomkovAA.Sprint2.Task0.V24.Lib;
namespace Tyuiu.KomkovAA.Sprint2.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            int x = 135;
            int y = 755;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] {true, true, false, false, true, true };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
