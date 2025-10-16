using Tyuiu.KomkovAA.Sprint2.Task2.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataServise ds = new DataServise();
        Console.Title = "Спринт #2 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
        Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
        Console.WriteLine("* области.                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение переменной X:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение переменной Y:");
        int y = Convert.ToInt32(Console.ReadLine());
        bool result = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (result == true)
        {
            Console.WriteLine($"Точка с координатами ({x};{y}) находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine($"Точка с координатами ({x};{y}) не находится в заштрихованной области");
        }
    }
}