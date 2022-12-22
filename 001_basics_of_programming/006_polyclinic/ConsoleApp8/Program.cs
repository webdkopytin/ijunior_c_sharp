using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int receptionTime = 10;
            int minutesInHour = 60;

            Console.WriteLine($"Внимание! Время приема одного человека равно {receptionTime} минутам.");

            Console.WriteLine("Введите кол-во людей в очереди: ");
            int peopleInLine = Convert.ToInt32(Console.ReadLine());

            int countMinutes = peopleInLine * receptionTime;
            int standInLineMinutes = countMinutes % minutesInHour;
            int standInLineHour = standInLineMinutes / minutesInHour;
            Console.WriteLine($"Вы должны отстоять в очереди {standInLineHour} часа и {standInLineMinutes} минут.");
            Console.ReadKey();
        }
    }
}
