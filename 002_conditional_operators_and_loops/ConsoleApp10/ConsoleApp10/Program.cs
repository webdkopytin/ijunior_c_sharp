using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumberRange = 100;
            int lastNumberRange = 999;
            int minNumber = 1;
            int maxNumber = 27;
            int counterMultipleNumbers = 0;

            Random random = new Random();
            int randomNumber = random.Next(minNumber, maxNumber);

            for (int currentNumber = 0; currentNumber < lastNumberRange; currentNumber += randomNumber)
            {
                if (currentNumber >= firstNumberRange)
                {
                    counterMultipleNumbers++;
                }
            }

            Console.WriteLine($"Количество трехзначных чисел, кратных {randomNumber} = {counterMultipleNumbers}");
            Console.ReadKey();
        }
    }
}