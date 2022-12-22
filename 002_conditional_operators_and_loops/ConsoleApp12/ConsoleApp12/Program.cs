using System;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userString;

            char openBracket = '(';
            char closedBracket = ')';

            int depth = 0;
            int maxDepth = 0;

            Console.Write($"Введите строку из символов '{openBracket}' и '{closedBracket}': ");
            userString = Console.ReadLine();

            foreach (var symbol in userString)
            {
                if (symbol == openBracket)
                {
                    depth++;
                }
                else if (symbol == closedBracket)
                {
                    depth--;
                }

                if (depth < 0)
                {
                    break;
                }

                if (depth > maxDepth)
                {
                    maxDepth = depth;
                }
            }

            if (depth == 0)
            {
                Console.WriteLine("Корректное скобочное выражение. Максимальная глубина: " + maxDepth);
            }
            else
            {
                Console.WriteLine("Не корректное скобочное выражение");
            }

            Console.ReadKey();
        }
    }
}
