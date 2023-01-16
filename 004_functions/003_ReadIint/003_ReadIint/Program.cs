using System;

namespace _003_ReadIint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultParse = GetNumber();

            Console.WriteLine("Выполнено успешно! Сконвертированное число: " + resultParse);
            Console.ReadKey();
        }

        static int GetNumber()
        {
            int result = 0;

            bool isWorking = true;

            while (isWorking)
            {
                Console.Write("Попытка конвертации в тип int (с помощью int.TryParse): ");
                string stringToNumber = Console.ReadLine();

                if (int.TryParse(stringToNumber, out result))
                    isWorking = false;
                else
                    Console.WriteLine("Неуспешно, повторная попытка...");
            }

            return result;
        }
    }
}