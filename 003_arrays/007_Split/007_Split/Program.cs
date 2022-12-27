using System;

namespace _007_Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Unity Junior Developer";

            string[] arrayWord = phrase.Split(' ');

            for (int i = 0; i < arrayWord.Length; i++)
            {
                Console.WriteLine(arrayWord[i]);
            }

            Console.ReadKey();
        }
    }
}
