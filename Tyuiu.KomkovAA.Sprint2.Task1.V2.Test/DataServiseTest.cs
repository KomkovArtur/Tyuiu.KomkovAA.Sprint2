using Tyuiu.KomkovAA.Sprint2.Task1.V2.Lib;
namespace Tyuiu.KomkovAA.Sprint2.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            int a = 135;
            int b = 156;
            int c = 154;
            int d = 174;
            bool[] wait = new bool[6] {true, true, true, true, true, false};
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(res, wait);
            
        }
    }
}
