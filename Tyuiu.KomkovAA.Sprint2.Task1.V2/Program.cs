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
        Console.Title = "Спринт #0 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
        Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
        Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^,                   *");
        Console.WriteLine("* последовательность операций не должна нарушаться), а также              *");
        Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность  *");
        Console.WriteLine("* (массив): (True, True, True, True, True, False), при a = 135, b = 156,  *");
        Console.WriteLine("* c = 154, d = 174*");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("a = 135");
        Console.WriteLine("b = 156");
        Console.WriteLine("a = 154");
        Console.WriteLine("b = 174");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

    }
}