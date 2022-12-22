using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int startRandomNumber = 1;
            int endRandomNumber = 100;
            int number = random.Next(startRandomNumber, endRandomNumber);
            int result = 0;
            int firstMultiples = 3;
            int secondMultiples = 5;

            for (int i = 0; i <= number; i++)
            {
                if (i % firstMultiples == 0 || i % secondMultiples == 0)
                {
                    result += i;
                }
            }

            Console.WriteLine($"Сумма всех положительных чисел меньше {number} = " + result);
            Console.ReadKey();
        }
    }
}
