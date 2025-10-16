using Tyuiu.KomkovAA.Sprint2.Task5.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:    *");
        Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3, масти «червы»   *");
        Console.WriteLine("* — 4, а достоинству карт: «валету» — 11, «даме» — 12, «королю» — 13,     *");
        Console.WriteLine("* «тузу» — 14 (порядковые номера карт остальных достоинств соответствуют  *");
        Console.WriteLine("* их названиям: «шестерка», «девятка» и т. п.). По заданным номеру масти  *");
        Console.WriteLine("* m (1 <= m <= 4) и номеру достоинства карты k (6 <= k <= 14) определить  *");
        Console.WriteLine("* полное название (масть и достоинство) соответствующей карты в виде      *");
        Console.WriteLine("* «Дама пик», Шестерка бубен» и т. п.                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        int a, b;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        var result = ds.FindCardNameAndValue(a, b);
        Console.WriteLine(result);
    }
}