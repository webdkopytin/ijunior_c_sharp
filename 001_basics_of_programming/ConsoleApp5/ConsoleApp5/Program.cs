using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int outputImagesRow = 3;
            int picturesInAlbum = 52;
            int fullyFilledRows = picturesInAlbum / outputImagesRow;
            int picturesBeyondMeasure = picturesInAlbum % outputImagesRow;
            Console.WriteLine($"Полностью заполненных рядов: {fullyFilledRows}. Сверх меры: {picturesBeyondMeasure}.");
            Console.ReadKey();
        }
    }
}
