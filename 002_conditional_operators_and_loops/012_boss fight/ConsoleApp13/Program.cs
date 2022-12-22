using System;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NumberSpellRashamon = 1;
            const int NumberSpellHyganzakyra = 2;
            const int NumberSpellIntergeron = 3;
            const int NumberSpellMemantin = 4;
            const int NumberSpellriftHPRestore = 5;

            int countBossHP = 5000;
            int countUserHP = 15000;
            int powerBossDamage = 1000;
            int powerUserDamage;
            int powerSpellRashamon = 100;
            int powerSpellHyganzakyra = 110;
            int powerSpellIntergeron = 120;
            int powerSpellMemantin = 130;
            int riftHPRestore = 250;
            int startCountStatisticFram = 0;
            int minimumHP = 0;
            int spellNumber;

            string stringStatistic;
            string frameSymbol;

            char symbolStatisticFrame = '-';

            bool useRashamon = false;
            bool useHyganzakyra = false;
            bool useIntergeron = false;

            string nameUserPerson = "Теневой маг";
            string spellRashamonDescription = $"\"Рашамон\" (наносит {powerSpellRashamon} ед. урона. Призывает теневого духа для нанесения атаки).";
            string spellHyganzakyraDescription = $"\"Хуганзакура\" (наносит {powerSpellHyganzakyra} ед.урона. Может быть выполнен только после призыва теневого духа).";
            string spellIntergeronDescription = $"\"Интерферон\" (наносит {powerSpellIntergeron} ед.урона. Может быть выполнен только после использования Хуганзакура).";
            string spellMemantinDescription = $"\"Мемантин\" (наносит {powerSpellMemantin} ед.урона. Может быть выполнен только после использования Интерферон).";
            string spellInterdimensionalRiftDescription = $"\"Межпространственный разлом\" (урон босса по вам не проходит. Позволяет скрыться в разломе и восстановить {riftHPRestore} хп).";

            Console.WriteLine(
                    $"Приветствую тебя {nameUserPerson}!\n" +
                    $"Тебе предстоит бой с Боссом, который очень силён!\n" +
                    $"У тебя есть выученные заклинания!"
                );

            while (countBossHP > minimumHP && countUserHP > minimumHP)
            {
                frameSymbol = "";

                stringStatistic = $"| HP Босса: {countBossHP} | HP Игрока {countUserHP} |";

                for (int i = startCountStatisticFram; i < stringStatistic.Length; i++)
                {
                    frameSymbol += Convert.ToString(symbolStatisticFrame);
                }

                Console.Write(
                        $"{frameSymbol}\n" +
                        $"{stringStatistic}\n" +
                        $"{frameSymbol}\n" +
                        $"{NumberSpellRashamon}) {spellRashamonDescription}\n" +
                        $"{NumberSpellHyganzakyra}) {spellHyganzakyraDescription}\n" +
                        $"{NumberSpellIntergeron}) {spellIntergeronDescription}\n" +
                        $"{NumberSpellMemantin}) {spellMemantinDescription}\n" +
                        $"{NumberSpellriftHPRestore}) {spellInterdimensionalRiftDescription}\n" +
                        $"Следующий шаг за тобой: "
                    );
                spellNumber = Convert.ToInt32(Console.ReadLine());

                switch (spellNumber)
                {
                    case NumberSpellRashamon:
                        useRashamon = true;
                        powerUserDamage = powerSpellRashamon;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Вы нанесли {powerUserDamage} урона");
                        Console.ForegroundColor = ConsoleColor.White;

                        countBossHP -= powerUserDamage;
                        break;

                    case NumberSpellHyganzakyra:
                        if (useRashamon)
                        {
                            useHyganzakyra = true;
                            powerUserDamage = powerSpellRashamon + powerSpellHyganzakyra;

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Вы нанесли {powerUserDamage} урона");
                            Console.ForegroundColor = ConsoleColor.White;

                            countBossHP -= powerUserDamage;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"ВНИМАНИЕ! Сначала используйте {spellRashamonDescription}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        break;

                    case NumberSpellIntergeron:
                        if (useHyganzakyra)
                        {
                            useIntergeron = true;
                            powerUserDamage = powerSpellRashamon + powerSpellHyganzakyra + powerSpellIntergeron;

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Вы нанесли {powerUserDamage} урона");
                            Console.ForegroundColor = ConsoleColor.White;

                            countBossHP -= powerUserDamage;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"ВНИМАНИЕ! Сначала используйте {spellHyganzakyraDescription}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        break;

                    case NumberSpellMemantin:
                        if (useIntergeron)
                        {
                            powerUserDamage = powerSpellRashamon + powerSpellHyganzakyra + powerSpellIntergeron + powerSpellMemantin;

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Вы нанесли {powerUserDamage} урона");
                            Console.ForegroundColor = ConsoleColor.White;

                            countBossHP -= powerUserDamage;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"ВНИМАНИЕ! Сначала используйте {spellIntergeronDescription}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        break;

                    case NumberSpellriftHPRestore:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Вы скрылись в разломе и восстановили себе: {riftHPRestore} HP");
                        Console.ForegroundColor = ConsoleColor.White;

                        countUserHP += riftHPRestore;

                        break;
                }

                if (countBossHP <= 0 && countBossHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ничья!!!");
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                }
                
                if (countBossHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Босс убит!!!");
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                }

                countUserHP -= powerBossDamage;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Босс нанес вам {powerBossDamage} урона");
                Console.ForegroundColor = ConsoleColor.White;

                if (countUserHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Игрок убит!!!");
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
