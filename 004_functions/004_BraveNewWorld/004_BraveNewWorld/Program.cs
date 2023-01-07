using System;
using System.IO;

namespace _004_BraveNewWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            
            bool isPlaing = true;

            int snakeX, snakeY;
            int snakeDX = 0, snakeDY = 1;

            string mapName = "Map1";

            char[,] map = ReadMap(mapName, out snakeX, out snakeY);

            DrawMap(map);

            while (isPlaing)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    switch(key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            snakeDX = -1;
                            snakeDY = 0;
                            break;
                        
                        case ConsoleKey.DownArrow:
                            snakeDX = 1;
                            snakeDY = 0;
                            break;

                        case ConsoleKey.LeftArrow:
                            snakeDX = 0;
                            snakeDY = -1;
                            break;

                        case ConsoleKey.RightArrow:
                            snakeDX = 0;
                            snakeDY = 1;
                            break;
                    }

                    if(map[snakeX + snakeDX, snakeY + snakeDY] != '#')
                    {
                        Console.SetCursorPosition(snakeY, snakeX);
                        Console.WriteLine(" ");

                        snakeX += snakeDX;
                        snakeY += snakeDY;

                        Console.SetCursorPosition(snakeY, snakeX);
                        Console.WriteLine('o');
                    }
                }
            }
        }

        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }

                Console.WriteLine();
            }
        }

        static char[,] ReadMap(string mapName, out int snakeX, out int snakeY)
        {
            snakeX = 0;
            snakeY = 0;

            string[] readMap = File.ReadAllLines($"{mapName}.txt");

            char[,] map = new char[readMap.Length, readMap[0].Length];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = readMap[i][j];

                    if (map[i, j] == 'o')
                    {
                        snakeX = i;
                        snakeY = j;
                    }
                }
            }

            return map;
        }
    }
}