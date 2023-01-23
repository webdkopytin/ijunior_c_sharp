using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _005_MergingCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listResult = new List<string>();

            string[] firstArray = new string[] { "1", "2", "1" };
            string[] secondArray = new string[] { "3", "2" };

            CheckRepetitions(firstArray, listResult);
            CheckRepetitions(secondArray, listResult);

            foreach (string resultStringArray in listResult)
                Console.Write(resultStringArray.ToString() + " ");

            Console.ReadKey();
        }

        static void CheckRepetitions(string[] curentArray, List<string> listResult)
        {
            for (int i = 0; i < curentArray.Length; i++)
            {
                for (int j = 0; j < curentArray.Length; j++)
                {
                    if (i != j && !listResult.Contains(curentArray[i]))
                        listResult.Add(curentArray[i]);
                }
            }
        }
    }
}