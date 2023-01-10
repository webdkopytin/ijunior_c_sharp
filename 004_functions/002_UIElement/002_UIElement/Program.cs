using System;

namespace _002_UIElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 10;
            int maxHealth = 10;
            int mana = 10;
            int maxMana = 10;

            bool isOpen = true;

            while (isOpen)
            {
                DrawBar(health, maxHealth, ConsoleColor.Red, 0, '_');
                DrawBar(mana, maxMana, ConsoleColor.Blue, 1, '_');

                Console.SetCursorPosition(0, 5);

                Console.Write("Введите на сколько изменятся жизни: ");
                health += Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите на сколько изменится мана: ");
                mana += Convert.ToInt32(Console.ReadLine());

                Console.Clear();
            }
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol = ' ')
        {
            if (value > 0 && value <= maxValue)
            {
                ConsoleColor defaultColor = Console.BackgroundColor;
                string bar = "";

                for (int i = 0; i < value; i++)
                {
                    bar += symbol;
                }

                Console.SetCursorPosition(0, position);

                Console.Write('[');
                Console.BackgroundColor = color;

                Console.Write(bar);
                Console.BackgroundColor = defaultColor;

                bar = "";

                for (int i = value; i < maxValue; i++)
                {
                    bar += symbol;
                }

                Console.Write(bar + "]\n");
            }
            else
            {
                Console.WriteLine("Введено отрицательное или превышающее предел значение");
            }
        }
    }
}
