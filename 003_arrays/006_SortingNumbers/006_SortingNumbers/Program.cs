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
            int countSwap = 0;

            bool isOpenSwap = true;

            int[] array = new int[lengthArray];

            Random random = new Random();

            Console.Write("Исходный массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(firstRandomNumber, lastRandomNumber);

                Console.Write(array[i] + " ");
            }

            Console.Write("\nОтсортированный массив: ");

            while (isOpenSwap)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    firstTempNumber = array[i];
                    secondTempNumber = array[i + 1];

                    if (firstTempNumber > secondTempNumber)
                    {
                        array[i] = secondTempNumber;
                        array[i + 1] = firstTempNumber;
                        countSwap++;
                    }
                }

                if (countSwap == 0)
                    isOpenSwap = false;
                else
                    countSwap = 0;
            }

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
