using System;
using System.Collections.Generic;

namespace _003_DataBasePlayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBasePlayers dataBase = new DataBasePlayers();

            dataBase.Work();
        }

        class DataBasePlayers
        {
            private bool _isWork;

            private List<Player> _players = new List<Player>();

            public void AddPlayer()
            {
                string name;
                string level;
                int result;
                bool isStringNumber;

                Console.Write("Введите никнейм игрока: ");
                name = Console.ReadLine();

                Console.Write("Введите уровень игрока: ");
                isStringNumber = CheckString(out level, out result);

                if (isStringNumber)
                {
                    _players.Add(new Player(name, result));
                }
                else
                {
                    GetMessege("Введите корректные данные");
                }
                Console.Clear();
            }

            private void GetMessege(string message)
            {
                Console.WriteLine(message);
                Console.ReadKey();
                Console.Clear();
            }

            private bool CheckString(out string userInput, out int result)
            {
                userInput = " ";
                result = 0;
                bool isStringNumber;

                userInput = Console.ReadLine();
                isStringNumber = int.TryParse(userInput, out result);
                return isStringNumber;
            }

            public void DeletePlayer()
            {

            }

            public void Work()
            {

            }
        }

        class Player
        {
            private string _name;
            private int _level;
            private string _flag;
            public bool IsBanned { get; private set; }

            public Player(string name, int level)
            {
                _name = name;
                _level = level;
                IsBanned = false;
            }

            public void SetBanPlayer()
            {

            }

            public void UnBanPlayer()
            {

            }
        }
    }
}
