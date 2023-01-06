using System;

namespace _003_ReadIint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultParse = ParseStringToInt();

            Console.WriteLine("Выполнено успешно! Сконвертированное число: " + resultParse);
            Console.ReadKey();
        }

        static int ParseStringToInt()
        {
            int result = 0;

            bool isOpen = true;

            while (isOpen)
            {
                Console.Write("Попытка конвертации в тип int (с помощью int.TryParse): ");
                string stringToNumber = Console.ReadLine();

                if (int.TryParse(stringToNumber, out result))
                    isOpen = false;
                else
                    Console.WriteLine("Неуспешно, повторная попытка...");
            }

            return result;
        }
    }
}