using System;

namespace _003_DataBasePlayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = {
                new Player(1, "FirstSkin", 10, false),
                new Player(2, "Monkey", 14, false),
                new Player(3, "UserMonk", 21, true)
            };

            BanPlayer(players, 1);
            ShowAllPlayers(players);

            UnBanPlayer(players, 2);
            ShowAllPlayers(players);

            Console.ReadKey();
        }

        static void ShowAllPlayers(Player[] players)
        {
            for (int i = 0; i < players.Length; i++)
                players[i].ShowStats();

            Console.WriteLine();
        }

        static void BanPlayer(Player[] players, int id)
        {
            players[id].BanPlayer();
        }

        static void UnBanPlayer(Player[] players, int id)
        {
            players[id].UnBanPlayer();
        }

        class Player
        {
            public Player(int id, string nikName, int level, bool flag)
            {
                Id = id;
                NikName = nikName;
                Level = level;
                Flag = flag;
            }

            public int Id { get; private set; }
            public string NikName { get; private set; }
            public int Level { get; private set; }
            public bool Flag { get; private set; }

            public void AddPlayer()
            {

            }

            public void DeletePlayer()
            {

            }

            public void ShowStats()
            {
                Console.Write($"\n{Id}) ник: {NikName}, уровень: {Level}, забанен: {Flag}");
            }

            public void BanPlayer()
            {
                Flag = true;
            }

            public void UnBanPlayer()
            {
                Flag = false;
            }
        }
    }
}
