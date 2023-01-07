using System;
using System.IO;

namespace _004_BraveNewWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mapName = "Map1";

            char[,] map = ReadMap(mapName);

            DrawMap(map);

            Console.ReadKey();
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

        static char[,] ReadMap(string mapName)
        {
            string[] readMap = File.ReadAllLines($"{mapName}.txt");

            char[,] map = new char[readMap.Length, readMap[0].Length];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = readMap[i][j];
                }
            }

            return map;
        }
    }
}