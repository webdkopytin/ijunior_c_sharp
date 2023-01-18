using System;
using System.Collections.Generic;

namespace _002_QueueStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deposit = 0;

            Dictionary<int, int[]> queueBuyers = new Dictionary<int, int[]>()
            {
                [1] = new int[] { 1433, 300, 434, 595, 6333 },
                [2] = new int[] { 100, 344, 4234 },
                [3] = new int[] { 234, 3454, 1238 }
            };

            Queue<int> purchaseSize = new Queue<int>();

            for (int i = 1; i <= queueBuyers.Count; i++)
            {
                for (int j = 0; j < queueBuyers[i].Length; j++)
                {
                    Console.Write(queueBuyers[i][j] + " ");

                    deposit += queueBuyers[i][j];
                }

                Console.WriteLine($"\n\n{i}й клиент ушел. Общий счет в кассе сегодня: {deposit} рублей");
                Console.WriteLine("Для продолжения нажмите любую кнопку!\n\n");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
