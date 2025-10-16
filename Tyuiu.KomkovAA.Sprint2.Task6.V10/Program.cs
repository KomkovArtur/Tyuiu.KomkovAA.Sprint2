using Tyuiu.KomkovAA.Sprint2.Task6.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g (год),*");
        Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным g, n и m           *");
        Console.WriteLine("* определить дату предыдущего дня. Заданный год не является високосным.   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        Console.WriteLine("Введите номер дня: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите номер месяца: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите номер года: ");
        int g = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              ");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("Дата предыдущего дня: " + ds.FindDateOfPreviousDay(g, m, n));


    }
}