using tyuiu.cources.programming.interfaces.Sprint2;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KomkovAA.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string res;
            switch (n)
            {
                case 1:

                    switch (m)
                    {
                        case 1:
                            n = 31;
                            m = 12;
                            g--;
                            break;
                        default:
                            m--;
                            switch (m)
                            {
                                case 1:
                                case 3:
                                case 5:
                                case 7:
                                case 8:
                                case 10:
                                    n = 31;
                                    break;
                                case 2:
                                    n = 28;
                                    break;
                                default:
                                    n = 30;
                                    break;
                            }
                            break;
                    }
                    break;
                default:
                    n--;
                    break;
            }
            if (n >= 10 & m >= 10)
                res = ($"{n}.{m}.{g}");

            else if (n < 10 & m < 10)
                res = ($"0{n}.0{m}.{g}");

            else if (n < 10 & m >= 10)
                res = ($"0{n}.{m}.{g}");

            else
                res = ($"{n}.0{m}.{g}");

            return res;

        }
    }
}
