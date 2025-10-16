using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KomkovAA.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string result = "";

            switch (value1)
            {
                case 1:
                    result += "пик";
                    break;
                case 2:
                    result += "треф";
                    break;
                case 3:
                    result += "бубен";
                    break;
                case 4:
                    result += "червей";
                    break;

            }

            switch (value2)
            {
                case 6:
                    result = "шестерка " + result;
                    break;
                case 11:
                    result = "валет " + result;
                    break;
                case 12:
                    result = "дама " + result;
                    break;
                case 13:
                    result = "король " + result;
                    break;
                case 14:
                    result = "туз " + result;
                    break;
                case 7:
                    result = "семерка " + result;
                    break;
                case 8:
                    result = "восьмерка " + result;
                    break;
                case 9:
                    result = "девятка " + result;
                    break;
                case 10:
                    result = "десятка " + result;
                    break;
            }

            return result;
        }
    }
}
