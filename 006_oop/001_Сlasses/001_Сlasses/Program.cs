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
            public string Name;
            public int Health;
            public int Mana;

            public Player(string name, int health, int mana)
            {
                this.Name = name;
                this.Health = health;
                this.Mana = mana;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Имя игрока: {Name}\nКоличество жизней: {Health}\nКоличество маны: {Mana}");
            }
        }
    }
}
