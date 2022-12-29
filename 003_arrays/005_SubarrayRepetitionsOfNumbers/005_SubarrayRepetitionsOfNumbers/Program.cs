using System;

namespace _005_SubarrayRepetitionsOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeSpecifiedArray = 30;
            int counter = 1;
            int numberReply = 0;
            int repeatNumber = 0;
            int minRandom = 1;
            int maxRandom = 31;

            int[] array = new int[sizeSpecifiedArray];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minRandom, maxRandom);

                Console.Write(array[i] + " ");
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    ++counter;
                }
                else if (numberReply < counter)
                {
                    numberReply = counter;
                    repeatNumber = array[i - 1];
                    counter = 1;
                }
            }

            Console.WriteLine($"\nЧисло {repeatNumber} повторяется {numberReply} раз подряд");
            Console.ReadKey();
        }
    }
}