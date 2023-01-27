using System;

namespace _002_WorkingProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Draw draw = new Draw();
            Player player = new Player(5, 5);

            draw.DrawPlayer(player.PositionX, player.PositionY);

            Console.ReadKey();
        }

        class Player
        {
            public Player(int positionX, int positionY)
            {
                PositionX = positionX;
                PositionY = positionY;
            }

            public int PositionX { get; private set; }
            public int PositionY { get; private set; }
        }

        class Draw
        {
            public void DrawPlayer(int positionX, int positionY, char symbolUser = '@')
            {
                Console.SetCursorPosition(positionX, positionY);
                Console.Write(symbolUser);
            }
        }
    }
}
