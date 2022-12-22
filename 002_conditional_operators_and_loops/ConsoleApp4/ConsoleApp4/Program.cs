using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startSequence = 5;
            int step = 7;

            Console.Write("Введите предел выстраиваемой последовательности: ");
            int endSequence = Convert.ToInt32(Console.ReadLine());

            for (int i = startSequence; i < endSequence; i += step)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }
    }
}
