using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите, сколько золота у вас есть сейчас: ");
            int countGoldNow = Convert.ToInt32(Console.ReadLine());
            int priceCrystal = 20;
            Console.Write($"Сколько кристаллов купить? Цена одного - {priceCrystal}. Введите кол-во: ");
            int countBuyCrystals = Convert.ToInt32(Console.ReadLine());
            countGoldNow -= priceCrystal * countBuyCrystals;
            Console.WriteLine($"Остаток золота - {countGoldNow}, остаток кристаллов {countBuyCrystals}");
            Console.ReadKey();
        }
    }
}
