using System;
using System.Collections.Generic;

namespace _003_DataBasePlayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MenuAddPlayer = 1;
            const int MenuDeletePlayer = 2;
            const int MenuBanPlayer = 3;
            const int MenuUnbanPlayer = 4;
            const int MenuExit = 5;

            bool isWork = true;

            Database database = new Database();

            while (isWork)
            {
                Console.Clear();

                database.ShowData();

                Console.WriteLine(
                    $"\n{MenuAddPlayer}. Добавить нового игрока" +
                    $"\n{MenuDeletePlayer}. Удалить игрока" +
                    $"\n{MenuBanPlayer}. Забанить игрока" +
                    $"\n{MenuUnbanPlayer}. Разбанить игрока" +
                    $"\n{MenuExit}. Выход"
                    );

                Console.Write("\nВаш выбор: ");
                int input = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (input)
                {
                    case MenuAddPlayer:
                        database.AddPlayer();
                        break;

                    case MenuDeletePlayer:
                        database.DeletePlayer();
                        break;

                    case MenuBanPlayer:
                        database.BanPlayer();
                        break;

                    case MenuUnbanPlayer:
                        database.UnbanPlayer();
                        break;

                    case MenuExit:
                        isWork = false;
                        break;

                    default:
                        Console.WriteLine("Неверная команда"); Console.ReadKey();
                        break;
                }
            }
        }

        internal class Database
        {
            private List<Player> _players = new List<Player>();
            private List<int> _deletedIDs = new List<int>();
            private int _lastID = 0;

            public void AddPlayer()
            {
                string nickName = "";
                string input;

                int level;

                bool isNickNameCorrect = false;

                Console.WriteLine("Введите никнейм:");

                while (isNickNameCorrect == false)
                {
                    input = Console.ReadLine();

                    isNickNameCorrect = (SearchPlayerByNickName(input) == null) &&
                    (input != string.Empty) && (Int32.TryParse(input, out int value) == false);

                    if (isNickNameCorrect == false)
                        Console.WriteLine("Не корректный никнейм введите другой:");
                    else
                        nickName = input;
                }

                Console.WriteLine("Введите уровень:");
                level = GetInputInt();

                Player player = new Player(GenerateID(), nickName, level);

                _players.Add(player);
            }

            public void DeletePlayer()
            {
                Player player = GetPlayerByID();

                if (player != null)
                {
                    _deletedIDs.Add(player.ID);
                    _players.Remove(player);
                }
            }

            public void BanPlayer()
            {
                Player player = GetPlayerByID();

                if (player != null)
                    player.Ban();
            }

            public void UnbanPlayer()
            {
                Player player = GetPlayerByID();

                if (player != null)
                    player.Unban();
            }

            public void ShowData()
            {
                foreach (var player in _players)
                {
                    Console.WriteLine(player.GetInfo());
                }
            }

            public Player GetPlayerByID()
            {
                if (_players.Count == 0)
                    return null;

                Console.WriteLine("Введите id игрока:");
                int id = GetInputInt();

                foreach (var player in _players)
                {
                    if (player.ID == id)
                    {
                        return player;
                    }
                }

                Console.WriteLine("Игрок не найден");
                Console.ReadLine();

                return null;
            }

            public Player SearchPlayerByNickName(string nickName)
            {
                foreach (var player in _players)
                {
                    if (player.NickName == nickName)
                    {
                        return player;
                    }
                }

                return null;
            }

            public int GenerateID()
            {
                if (_deletedIDs.Count == 0)
                {
                    return ++_lastID;
                }
                else
                {
                    int id = _deletedIDs[0];
                    _deletedIDs.RemoveAt(0);
                    return id;
                }
            }

            private static int GetInputInt()
            {
                bool isInputInteger = false;

                string input;

                int result = 0;

                while (isInputInteger == false)
                {
                    input = Console.ReadLine();
                    isInputInteger = Int32.TryParse(input, out int value);

                    if (isInputInteger == false)
                        Console.WriteLine("Необходимо ввести число:");
                    else
                        result = value;
                }

                return result;
            }
        }

        internal class Player
        {
            public int ID { get; }
            public string NickName { get; }
            public int Level { get; }
            public bool IsBanned { get; private set; } = false;

            public Player(int id, string nickName, int level)
            {
                ID = id;
                NickName = nickName;
                Level = level;
            }

            public void Ban()
            {
                IsBanned = true;
            }

            public void Unban()
            {
                IsBanned = false;
            }

            public string GetInfo()
            {
                return $"id: {ID}\tник: {NickName}\tуровень: {Level}\tзабанен: {IsBanned}";
            }
        }
    }
}
