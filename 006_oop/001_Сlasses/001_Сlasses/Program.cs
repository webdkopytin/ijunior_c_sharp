using System;

namespace _001_Сlasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player firstPlayer = new Player("Vitory", 100, 100);

            firstPlayer.ShowInfo();

            Console.ReadKey();
        }

        class Player
        {
            private string _name;
            private int _health;
            private int _mana;

            public Player(string name, int health, int mana)
            {
                _name = name;
                _health = health;
                _mana = mana;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Имя игрока: {_name}\nКоличество жизней: {_health}\nКоличество маны: {_mana}");
            }
        }
    }
}
