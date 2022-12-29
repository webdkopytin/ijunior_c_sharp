using System;

namespace _008_ShiftingArrayValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempNumber;
            int countShift;

            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.Write("Введите число, на которое сдвинуть массив: ");
            countShift = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                tempNumber = array[i];

                if (i < array.Length - countShift)
                {
                    array[i] = array[i + countShift];
                    array[i + countShift] = tempNumber;
                }
                else
                {
                    array[i] = tempNumber;
                }

                Console.Write(array[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
