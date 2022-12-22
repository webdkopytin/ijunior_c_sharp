using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitStatus = false;

            while (exitStatus == false)
            {
                Console.Write("Введите любое слово: ");
                string nameWorld = Console.ReadLine();

                if (nameWorld == "exit")
                {
                    exitStatus = true;
                }
            }
        }
    }
}
