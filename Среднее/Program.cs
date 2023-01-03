using System.Globalization;
using Среднее;

СписокInt тест = new СписокInt();




while (true)
{
    Console.WriteLine($"Напишите число {тест.Количество + 1}");
    string? one = Console.ReadLine();
    if (one == "")
    {
        Console.WriteLine("Вод приостоновленым пользователем");
        break;
    }
    if (int.TryParse(one, out int value))
    {
        тест.Добавить(value);

    }
}

int[] масив = тест.ПолучитьМассив();
Console.Write($"Массив из {масив.Length} элементов. ");
foreach (int p in масив)
    Console.Write($" {p};");

Console.WriteLine();
Console.WriteLine($"Сумма чисел {тест.Сумма()};" +
    $" Среднее {тест.Среднее()}; Максимум {тест.Максимум()}; Минимум {тест.Минимум()} ") ;

тест.Реверс();
int[] масив2 = тест.ПолучитьМассив();
Console.Write($"Массив из {масив2.Length} элементов. ");
foreach (int p in масив2)
    Console.Write($" {p};");

Console.WriteLine();
Console.WriteLine($"Сумма чисел {тест.Сумма()};" +
    $" Среднее {тест.Среднее()}; Максимум {тест.Максимум()}; Минимум {тест.Минимум()} ");







Console.ReadKey();

