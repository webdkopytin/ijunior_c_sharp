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

            GetRepetitions(firstArray, listResult);
            GetRepetitions(secondArray, listResult);

            foreach (string resultStringArray in listResult)
                Console.Write(resultStringArray.ToString() + " ");

            Console.ReadKey();
        }

        static void GetRepetitions(string[] curentArray, List<string> listResult)
        {
            for (int i = 0; i < curentArray.Length; i++)
            {
                if (listResult.Contains(curentArray[i]) == false)
                    listResult.Add(curentArray[i]);
            }
        }
    }
}