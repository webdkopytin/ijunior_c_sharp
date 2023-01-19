using System;
using System.Collections.Generic;

namespace _003_DynamicArrayPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandAmountNumbers = "sum";
            const string CommandExitProgram = "exit";

            bool isOpen = true;
            bool isNumber;

            string inputUserNumber;

            int resultParse;
            int resultSum = 0;

            List<int> inputNumbers = new List<int>();

            while (isOpen)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);

                Console.WriteLine($"{CommandAmountNumbers} - команда для вывода суммы всех введенных чисел.\n{CommandExitProgram} - команда для выхода из программы.\n");

                Console.Write("Программа запоминает введенные числа, текст игнорируется. Введите команду или число: ");
                inputUserNumber = Console.ReadLine();

                isNumber = int.TryParse(inputUserNumber, out resultParse);

                isOpen = inputUserNumber == CommandExitProgram ? false : true;

                if (isOpen && isNumber)
                    inputNumbers.Add(resultParse);

                if (inputUserNumber == CommandAmountNumbers)
                    GetSumAllInputNumbers(ref resultSum, inputNumbers);
            }
        }

        static void GetSumAllInputNumbers(ref int resultSum, List<int> inputNumbers)
        {
            foreach (int number in inputNumbers)
                resultSum += number;

            Console.WriteLine("Сумма всех введенных чисел = " + resultSum);
            Console.ReadKey();
        }
    }
}