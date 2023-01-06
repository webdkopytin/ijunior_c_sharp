using System;

namespace _003_ReadIint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;

            string stringToNumber = "";

            while (isOpen)
            {
                Console.Write("Попытка конвертации в тип int (с помощью int.TryParse): ");
                stringToNumber = Console.ReadLine();

                bool parseSuccessful = int.TryParse(stringToNumber, out int result);

                if (parseSuccessful)
                    isOpen = false;
                else
                    Console.WriteLine("Неуспешно, повторная попытка...");
            }

            Console.WriteLine("Выполнено успешно! Сконвертированное число: " + stringToNumber);
            Console.ReadKey();
        }
    }
}