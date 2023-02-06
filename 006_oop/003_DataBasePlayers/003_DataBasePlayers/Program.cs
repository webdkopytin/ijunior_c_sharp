using System;
using System.Collections.Generic;

namespace _003_DataBasePlayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int menuShowData = 1;
            const int menuAddPlayer = 2;
            const int menuDeletePlayer = 3;
            const int menuBanPlayer = 4;
            const int menuUnBanPlayer = 5;
            const int menuExit = 6;

            bool isWork = true;

            Database database = new Database();

            while (isWork)
            {
                Console.WriteLine(
                    $"\n{menuShowData}. Вывести данные всех игроков" +
                    $"\n{menuAddPlayer}. Добавить нового игрока" +
                    $"\n{menuDeletePlayer}. Удалить игрока" +
                    $"\n{menuBanPlayer}. Забанить игрока" +
                    $"\n{menuUnBanPlayer}. Разбанить игрока" +
                    $"\n{menuExit}. Выход"
                    );

                Console.Write("\nВаш выбор: ");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case menuShowData:
                        database.ShowData();
                        break;

                    case menuAddPlayer:
                        database.AddPlayer();
                        break;

                    case menuDeletePlayer:
                        database.DeletePlayer();
                        break;

                    case menuBanPlayer:
                        database.BanPlayer();
                        break;

                    case menuUnBanPlayer:
                        database.UnBanPlayer();
                        break;

                    case menuExit:
                        isWork = false;
                        break;
                }
            }
        }

        class Player
        {
            public string Name { get; private set; }
            public int Level { get; private set; }
            public bool IsBanned { get; private set; }

            public Player(string name, int level, bool isBanned)
            {
                Name = name;
                Level = level;
                IsBanned = isBanned;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Имя игрока: {Name} \nУровень игрока: {Level}");
                if (IsBanned)
                    Console.WriteLine("Есть у игрока бан: да");
                else
                    Console.WriteLine("Есть у игрока бан: нет");
            }

            public void Ban()
            {
                IsBanned = true;
            }

            public void UnBan()
            {
                IsBanned = false;
            }
        }

        class Database
        {
            private Dictionary<int, Player> _players = new Dictionary<int, Player>();
            private int _playerIndexInBase;

            public Database()
            {
                _playerIndexInBase = 0;
            }

            public void AddPlayer()
            {
                const string answerYes = "Да";
                const string answerNo = "Нет";
                
                bool isBanned;

                Console.WriteLine("\nВведите имя игрока: \n");
                string name = Console.ReadLine();

                Console.WriteLine("\nВведите уровень игрока: \n");
                bool isNumber = int.TryParse(Console.ReadLine(), out int level);

                if (isNumber == false)
                {
                    PrintRedText("\nНеккоретный ввод. Уровень должен содержать только числа\n");
                    return;
                }

                Console.WriteLine($"\nИгрок забанен? ({answerYes} или {answerNo}) \n");
                string input = Console.ReadLine();

                if (input == answerYes)
                {
                    isBanned = true;
                }
                else if (input == answerNo)
                {
                    isBanned = false;
                }
                else
                {
                    PrintRedText("\nНеккоретный ввод. Попробуйте ещё раз\n");
                    return;
                }

                _players.Add(_playerIndexInBase, new Player(name, level, isBanned));
                _playerIndexInBase++;

                PrintGreenText("\nИгрок добавлен!\n");
            }

            public void DeletePlayer()
            {
                Console.WriteLine("\nВведите уникальный номер игрока\n");
                bool isNumber = int.TryParse(Console.ReadLine(), out int input);

                if (isNumber & _players.ContainsKey(input))
                {
                    _players.Remove(input);
                    PrintGreenText("\nИгрок удалён!\n");
                }
                else
                {
                    PrintRedText("\nНеккоректный ввод или игрока с данным номером нет в базе\n");
                }
            }

            public void ShowData()
            {
                if (_players.Count != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    for (int i = 0; i < _players.Count; i++)
                    {
                        _players[i].ShowInfo();
                        Console.WriteLine($"Уникальный номер: {i}");
                        Console.WriteLine();
                    }

                    Console.ResetColor();
                }
                else
                {
                    PrintRedText("\nВ базе ещё нет игроков\n");
                }
            }

            public void BanPlayer()
            {
                Console.WriteLine("\nВведите уникальный номер игрока\n");
                bool isNumber = int.TryParse(Console.ReadLine(), out int input);

                if (isNumber & _players.ContainsKey(input))
                {
                    if (_players[input].IsBanned == false)
                    {
                        _players[input].Ban();
                        PrintGreenText("\nИгрок забанен!\n");
                    }
                    else
                    {
                        PrintRedText("\nИгрок уже забанен\n");
                    }
                }
                else
                {
                    PrintRedText("\nНеккоректный ввод или игрока с данным номером нет в базе\n");
                }
            }

            public void UnBanPlayer()
            {
                Console.WriteLine("\nВведите уникальный номер игрока\n");
                int input = int.Parse(Console.ReadLine());

                if (_players.ContainsKey(input))
                {
                    if (_players[input].IsBanned)
                    {
                        _players[input].UnBan();
                        PrintGreenText("\nИгрок разабанен!\n");
                    }
                    else
                    {
                        PrintRedText("\nУ игрока нет бана\n");
                    }
                }
                else
                {
                    PrintRedText("\nИгрока с данным номером нет в базе\n");
                }
            }

            public void PrintRedText(string text)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(text);
                Console.ResetColor();
            }

            public void PrintGreenText(string text)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(text);
                Console.ResetColor();
            }
        }
    }
}
