using System;

namespace ArrayApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            bool canViewSum = false;

            int[] saveNumbers = new int[0];
            int[] tempNumbers;

            string inputUserNumber;
            string commandAmountNumbers = "sum";
            string commandExitProgram = "exit";

            while (isOpen)
            {
                int sumAllNumbers = 0;

                Console.Clear();
                Console.SetCursorPosition(0, 20);
                Console.Write("Запомненные числа: ");

                foreach (int number in saveNumbers)
                {
                    Console.Write($"{number} ");
                    sumAllNumbers += number;
                }

                if (canViewSum)
                {
                    Console.SetCursorPosition(0, 18);
                    Console.Write($"Запомненные числа: {sumAllNumbers}");
                }

                tempNumbers = new int[saveNumbers.Length + 1];

                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"Доступны команды:\n{commandAmountNumbers} - выводит сумму всех введенных чисел\n{commandExitProgram} - выход из программы");
                Console.Write("\nВведите число, а программа его запомнит: ");

                inputUserNumber = Console.ReadLine();

                canViewSum = inputUserNumber == commandAmountNumbers ? true : false;
                isOpen = inputUserNumber == commandExitProgram ? false : true;

                if (canViewSum == false && isOpen == true)
                {
                    for (int i = 0; i < saveNumbers.Length; i++)
                    {
                        tempNumbers[i] = saveNumbers[i];
                    }

                    tempNumbers[tempNumbers.Length - 1] = Convert.ToInt32(inputUserNumber);
                    saveNumbers = tempNumbers;
                }
            }
        }
    }
}