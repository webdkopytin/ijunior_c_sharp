using System;
using System.Collections;
using System.Collections.Generic;

namespace _002_QueueStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // У вас есть множество целых чисел. Каждое целое число - это сумма покупки.
            // Вам нужно обслуживать клиентов до тех пор, пока очередь не станет пуста.
            // После каждого обслуженного клиента деньги нужно добавлять на наш счёт и выводить его в консоль.
            // После обслуживания каждого клиента программа ожидает нажатия любой клавиши, после чего затирает консоль и по новой выводит всю информацию,
            // только уже со следующим клиентом
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
                Console.WriteLine(queueBuyers);
            }

            Console.ReadKey();
        }
    }
}
