using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KomkovAA.Sprint2.Task1.V2.Lib
{
    public class DataServise : ISprint2Task1V2
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < d) | (b < c);
            res[1] = (a < d) & (d > c);
            res[2] = (a < b) || (b < c);
            res[3] = (a < b) && (b > c);
            res[4] = !(!res[0]);
            res[5] = (a < b) ^ (b > c);
            return res;



        }
    }
}
