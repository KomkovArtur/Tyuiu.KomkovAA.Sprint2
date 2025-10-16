using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KomkovAA.Sprint2.Task0.V24.Lib
{
    public class DataServise : ISprint2Task0V24
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = y == y;
            res[1] = x != y;
            res[2] = x > y;
            res[3] = y < x;
            res[4] = x <= y;
            res[5] = y >= x;

            return res;
        }
    }
}
