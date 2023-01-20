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

            string inputUserNumber;

            int resultParse = 0;

            List<int> inputNumbers = new List<int>();

            while (isOpen)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);

                Console.WriteLine($"{CommandAmountNumbers} - команда для вывода суммы всех введенных чисел.\n{CommandExitProgram} - команда для выхода из программы.\n");

                Console.Write("Программа запоминает введенные числа, текст игнорируется. Введите команду или число: ");
                inputUserNumber = Console.ReadLine();

                int.TryParse(inputUserNumber, out resultParse);

                switch (inputUserNumber)
                {
                    case CommandExitProgram:
                        isOpen = false;
                        break;

                    case CommandAmountNumbers:
                        ShowSumAllInputNumbers(inputNumbers);
                        break;

                    default:
                        inputNumbers.Add(resultParse);
                        break;
                }
            }
        }

        static void ShowSumAllInputNumbers(List<int> inputNumbers)
        {
            int resultSum = 0;

            foreach (int number in inputNumbers)
                resultSum += number;

            Console.WriteLine("Сумма всех введенных чисел = " + resultSum);
            Console.ReadKey();
        }
    }
}