using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ConversionRubToUsd = 1;
            const int ConversionRubToEur = 2;
            const int ConversionUsdToRub = 3;
            const int ConversionEurToRub = 4;
            const int ConversionUsdToEur = 5;
            const int ConversionEurToUsd = 6;
            const int ExitProgram = 7;

            float countRub = 10000;
            float countUsd = 1000;
            float countEur = 1000;
            float priceRubToUsd = 0.015783f;
            float priceRubToEur = 0.014826f;
            float priceUsdToEur = .94f;
            float priceEurToUsd = 1.06f;
            float countCurrency;

            bool haveEnoughMoney;
            bool isPressExit = false;

            Console.WriteLine($"Курс доллара: {priceRubToUsd} | Курс евро: {priceRubToEur}");
            Console.WriteLine("---------------------------------------------------");

            while (isPressExit == false)
            {
                Console.WriteLine($"Ваш баланс - Рубли: {countRub} | Доллары: {countUsd} | Евро: {countEur}");
                Console.WriteLine("---------------------------------------------------");

                Console.Write($"Направление конвертации:\n" +
                    $"({ConversionRubToUsd}) рубли в доллары\n" +
                    $"({ConversionRubToEur}) рубли в евро\n" +
                    $"({ConversionUsdToRub}) доллары в рубли\n" +
                    $"({ConversionEurToRub}) евро в рубли\n" +
                    $"({ConversionUsdToEur}) доллары в евро\n" +
                    $"({ConversionEurToUsd}) евро в доллары\n" +
                    $"({ExitProgram}) выход из обменника:\n" +
                    $"Выбирайте: ");
                int conversionDirection = Convert.ToInt32(Console.ReadLine());

                switch (conversionDirection)
                {
                    case ConversionRubToUsd:
                        Console.Write("Запрашиваемое кол-во необходимой валюты: ");
                        countCurrency = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Проверяем достаточно ли денег для обмена на ДОЛЛАРЫ.");
                        haveEnoughMoney = countRub >= countCurrency / priceRubToUsd;

                        if (haveEnoughMoney)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Проверка пройдена...\nВыдано {countCurrency} долларов.");
                            Console.ForegroundColor = ConsoleColor.White;

                            countRub -= countCurrency / priceRubToUsd;
                            countUsd += countCurrency;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Недостаточно денег для конвертации...");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;

                    case ConversionRubToEur:
                        Console.Write("Запрашиваемое кол-во необходимой валюты: ");
                        countCurrency = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Проверяем достаточно ли денег для обмена на ЕВРО.");
                        haveEnoughMoney = countRub >= countCurrency / priceRubToEur;

                        if (haveEnoughMoney)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Проверка пройдена...\nВыдано {countCurrency} евро.");
                            Console.ForegroundColor = ConsoleColor.White;

                            countRub -= countCurrency / priceRubToEur;
                            countEur += countCurrency;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно денег для конвертации...");
                        }
                        break;

                    case ConversionUsdToRub:
                        Console.Write("Запрашиваемое кол-во необходимой валюты: ");
                        countCurrency = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Проверяем достаточно ли денег для обмена на РУБЛИ.");
                        haveEnoughMoney = countUsd >= countCurrency / priceRubToUsd;

                        if (haveEnoughMoney)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Проверка пройдена...\nВыдано {countCurrency} руб.");
                            Console.ForegroundColor = ConsoleColor.White;

                            countUsd -= countCurrency / priceRubToUsd;
                            countRub += countCurrency;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно денег для конвертации...");
                        }
                        break;

                    case ConversionEurToRub:
                        Console.Write("Запрашиваемое кол-во необходимой валюты: ");
                        countCurrency = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Проверяем достаточно ли денег для обмена на РУБЛИ.");
                        haveEnoughMoney = countEur >= countCurrency / priceRubToEur;

                        if (haveEnoughMoney)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Проверка пройдена...\nВыдано {countCurrency} руб.");
                            Console.ForegroundColor = ConsoleColor.White;

                            countEur -= countCurrency / priceRubToEur;
                            countRub += countCurrency;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно денег для конвертации...");
                        }
                        break;

                    case ConversionUsdToEur:
                        Console.Write("Запрашиваемое кол-во необходимой валюты: ");
                        countCurrency = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Проверяем достаточно ли денег для обмена на евро.");
                        haveEnoughMoney = countUsd >= countCurrency / priceUsdToEur;

                        if (haveEnoughMoney)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Проверка пройдена...\nВыдано {countCurrency} евро");
                            Console.ForegroundColor = ConsoleColor.White;

                            countUsd -= countCurrency / priceUsdToEur;
                            countEur += countCurrency;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно денег для конвертации...");
                        }
                        break;

                    case ConversionEurToUsd:
                        Console.Write("Запрашиваемое кол-во необходимой валюты: ");
                        countCurrency = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Проверяем достаточно ли денег для обмена на доллары.");
                        haveEnoughMoney = countEur >= countCurrency / priceEurToUsd;

                        if (haveEnoughMoney)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Проверка пройдена...\nВыдано {countCurrency} долларов");
                            Console.ForegroundColor = ConsoleColor.White;

                            countEur -= countCurrency / priceEurToUsd;
                            countUsd += countCurrency;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно денег для конвертации...");
                        }
                        break;

                    case ExitProgram:
                        isPressExit = true;
                        break;
                }
            }
        }
    }
}