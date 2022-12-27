using System;

namespace _008_ShiftingArrayValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempNumber;
            int countShift = 2;

            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

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
