using System;

namespace _005_KansasCityShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "АБВГД";

            foreach (char resultChar in Shuffle(name))
            {
                Console.Write(resultChar);
            }

            Console.ReadKey();
        }

        static char[] Shuffle(string name)
        {
            int newRandIndex;

            Random random = new Random();

            char[] tempChars = name.ToCharArray();

            for (int i = 0; i < name.Length; i++)
            {
                newRandIndex = random.Next(i);

                (tempChars[i], tempChars[newRandIndex]) = (tempChars[newRandIndex], tempChars[i]);
            }

            return tempChars;
        }
    }
}
