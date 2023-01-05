using System.Globalization;
using Среднее;



class Program
{
    static public void Main(String[] args)
    {
        СписокInt тест = new СписокInt() {  Инциализация=2};
        


        

        ВодДанных(тест);

        тест= тест.Положительные();

        ВывестиДанные(тест);
        тест.Реверс();
        ВывестиДанные(тест);

        Console.ReadKey();
    }
    
      



    static void ВывестиДанные(СписокInt данные)
    {
        int[] масив = данные.ПолучитьМассив();
        Console.Write($"Массив из {масив.Length} элементов. ");
        foreach (int p in масив)
            Console.Write($" {p};");

        Console.WriteLine();
        Console.WriteLine($"Сумма чисел {данные.Сумма()};" +
            $" Среднее {данные.Среднее()}; Максимум {данные.Максимум()}; Минимум {данные.Минимум()} ");
    }

    static void ВодДанных(СписокInt данные)
    {
        while (true)
        {
            Console.WriteLine($"Напишите число {данные.Количество + 1}");
            string? one = Console.ReadLine();
            if (one == "")
            {
                Console.WriteLine("Вод приостоновленым пользователем");
                break;
            }
            if (int.TryParse(one, out int value))
            {
                данные.Добавить(value);

            }
        }
    }
}