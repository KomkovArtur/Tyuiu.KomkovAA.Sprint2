using Tyuiu.KomkovAA.Sprint2.Task1.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataServise ds = new DataServise();
        int a = 135;
        int b = 156;
        int c = 154;
        int d = 174;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

    }
}