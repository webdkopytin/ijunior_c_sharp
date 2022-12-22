using System;

namespace ArrayApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;

            int[] saveNumbers = new int[0];
            int[] tempNumbers;

            while (isOpen)
            {

                Console.Clear();
                Console.SetCursorPosition(0, 20);
                Console.Write("Запомненные числа: ");

                foreach (int number in saveNumbers)
                {
                    Console.Write($"{number} ");
                }

                tempNumbers = new int[saveNumbers.Length + 1];

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Доступны команды:\nsum - выводит сумму всех введенных чисел\nexit - выход из программы");
                Console.Write("\nВведите число, а программа его запомнит: ");
                int inputUserNumber = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < saveNumbers.Length; i++)
                {
                    tempNumbers[i] = saveNumbers[i];
                }

                tempNumbers[tempNumbers.Length - 1] = inputUserNumber;
                saveNumbers = tempNumbers;

                //TODO: Доделать выполнение sum, exit
            }

            Console.ReadKey();
        }
    }
}