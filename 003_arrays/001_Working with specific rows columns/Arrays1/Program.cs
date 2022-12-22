using System;

namespace Arrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CountColArray = 4;
            const int CountRowArray = 3;

            int sumSecondLine = 0;
            int multiplyFirstColumn = 1;
            int numberRowForSum = 1;
            int numberColumnForMultiply = 0;

            int[,] array = new int[CountColArray, CountRowArray] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
                { 5, 5, 5 },
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                multiplyFirstColumn *= array[i, numberColumnForMultiply];
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                sumSecondLine += array[numberRowForSum, i];
            }

            Console.WriteLine($"Произведение первого столбца = {multiplyFirstColumn}");
            Console.WriteLine($"Сумма второй строки = {sumSecondLine}");
            Console.ReadKey();
        }
    }
}
