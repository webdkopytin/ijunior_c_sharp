using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startPoint = 0;
            int endPoint;

            string name;
            string resultString;
            string frameForNumber ="";

            char symbol;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            Console.Write("Введите символ: ");
            symbol = Convert.ToChar(Console.ReadLine());

            resultString = symbol + name + symbol;
            endPoint = resultString.Length;

            for (int i = startPoint; i < endPoint; i++)
            {
                frameForNumber += Convert.ToString(symbol);
            }

            Console.Write($"\n{frameForNumber}\n{resultString}\n{frameForNumber}\n");
            Console.ReadKey();
        }
    }
}