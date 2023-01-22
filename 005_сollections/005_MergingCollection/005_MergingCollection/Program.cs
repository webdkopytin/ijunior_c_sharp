using System;
using System.Collections.Generic;

namespace _005_MergingCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listResult = new List<string>();

            string[] firstArray = new string[] { "1", "2", "1" };
            string[] secondArray = new string[] { "3", "2" };

            foreach (string record in firstArray)
                listResult.Add(record);

            for (int i = 0; i < secondArray.Length; i++)
            {
                if (!listResult.Contains(secondArray[i]))
                    listResult.Add(secondArray[i]);
            }

            foreach (string resultStringArray in listResult)
                Console.Write(resultStringArray.ToString() + " ");

            Console.ReadKey();
        }
    }
}