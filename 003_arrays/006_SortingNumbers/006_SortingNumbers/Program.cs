using System;

namespace _006_SortingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthArray = 10;
            int firstTempNumber;
            int secondTempNumber;
            int firstRandomNumber = 1;
            int lastRandomNumber = 10;

            int[] array = new int[lengthArray];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(firstRandomNumber, lastRandomNumber);
            }

            for (int i = 1; i < array.Length; i++)
            {
                firstTempNumber = array[i - 1];

                if (firstTempNumber > array[i])
                {
                    secondTempNumber = firstTempNumber;
                    firstTempNumber = array[i];
                    array[i] = secondTempNumber;
                }
            }

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
