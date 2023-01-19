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
            bool wallDefinition = true;

            int snakePositionX;
            int snakePositionY;
            int snakeDirectionX = 0;
            int snakeDirectionY = 1;

            char wallSymbol = '#';
            char snakeSymbol = 'o';

            string mapName = "Map1";

            char[,] map = ReadMap(mapName, snakeSymbol, out snakePositionX, out snakePositionY);

            DrawMap(map);

            while (isPlaing)
            {
                if (Console.KeyAvailable)
                {
                    SetDirection(ref snakeDirectionX, ref snakeDirectionY);

                    wallDefinition = map[snakePositionX + snakeDirectionX, snakePositionY + snakeDirectionY] != wallSymbol;

                    DrawMovement(wallDefinition, ref snakePositionX, ref snakePositionY, snakeDirectionX, snakeDirectionY, wallSymbol, snakeSymbol);
                }
            }
        }

        static void DrawMovement(bool wallDefinition, ref int snakePositionX, ref int snakePositionY, int snakeDirectionX, int snakeDirectionY, char wallSymbol, char snakeSymbol)
        {
            if (wallDefinition)
            {
                Console.SetCursorPosition(snakePositionY, snakePositionX);
                Console.WriteLine(" ");

                snakePositionX += snakeDirectionX;
                snakePositionY += snakeDirectionY;

                Console.SetCursorPosition(snakePositionY, snakePositionX);
                Console.WriteLine(snakeSymbol);
            }
        }

        static void SetDirection(ref int snakeDirectionX, ref int snakeDirectionY)
        {
            const ConsoleKey upArrow = ConsoleKey.UpArrow;
            const ConsoleKey downArrow = ConsoleKey.DownArrow;
            const ConsoleKey leftArrow = ConsoleKey.LeftArrow;
            const ConsoleKey rightArrow = ConsoleKey.RightArrow;

            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case upArrow:
                    snakeDirectionX = -1;
                    snakeDirectionY = 0;
                    break;

                case downArrow:
                    snakeDirectionX = 1;
                    snakeDirectionY = 0;
                    break;

                case leftArrow:
                    snakeDirectionX = 0;
                    snakeDirectionY = -1;
                    break;

                case rightArrow:
                    snakeDirectionX = 0;
                    snakeDirectionY = 1;
                    break;
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

        static char[,] ReadMap(string mapName, char snakeSymbol, out int snakeX, out int snakeY)
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

                    if (map[i, j] == snakeSymbol)
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