using System;
using System.Collections.Generic;

namespace _004_PersonnelAccountingPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CommandAddRecord = 1;
            const int CommandViewAllRecords = 2;
            const int CommandDeleteRecord = 3;
            const int CommandExit = 4;

            bool isOpen = true;
            bool isCommand;

            int parseCommand;

            string inputFirstLastName = "";
            string inputPosition = "";
            string inputCommand;

            Dictionary<string, string> dossierArchive = new Dictionary<string, string>();

            while (isOpen)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);

                Console.WriteLine(
                        $"{CommandAddRecord} - добавить досье\n" +
                        $"{CommandViewAllRecords} - вывести все досье\n" +
                        $"{CommandDeleteRecord} - удалить досье\n" +
                        $"{CommandExit} - выход\n"
                    );

                Console.Write("Введите команду: ");
                inputCommand = Console.ReadLine();

                isCommand = int.TryParse(inputCommand, out parseCommand);

                if (isCommand && isOpen)
                {
                    switch (parseCommand)
                    {
                        case CommandAddRecord:
                            AddRecord(inputFirstLastName, inputPosition, dossierArchive);
                            break;

                        case CommandViewAllRecords:
                            ViewAllRecords(dossierArchive);
                            break;

                        case CommandDeleteRecord:
                            DeleteRecord(dossierArchive);
                            break;

                        case CommandExit:
                            isOpen = false;
                            break;
                    }
                }
            }
        }

        static void AddRecord(string inputFirstLastName, string inputPosition, Dictionary<string, string> dossierArchive)
        {
            Console.Write("Введите ФИО: ");
            inputFirstLastName = Console.ReadLine();

            Console.Write("Введите должность: ");
            inputPosition = Console.ReadLine();

            dossierArchive.Add(inputFirstLastName, inputPosition);

            Console.WriteLine($"\n\nЗапись добавлена.\nДля продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }

        static void ViewAllRecords(Dictionary<string, string> dossierArchive)
        {
            foreach (var record in dossierArchive)
            {
                Console.Write("\n" + record.Key + " - " + record.Value);
            }

            Console.WriteLine($"\n\nВыведены все записи.\nДля продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }

        static void DeleteRecord(Dictionary<string, string> dossierArchive)
        {
            Console.Write("Введите ФИО человека, которого необходимо удалить из досье: ");
            string deleteFirstLastName = Console.ReadLine();

            if (dossierArchive.ContainsKey(deleteFirstLastName))
            {
                dossierArchive.Remove(deleteFirstLastName);

                Console.WriteLine($"\n\nЗапись удалена.\nДля продолжения нажмите любую кнопку...");
            }
            else
            {
                Console.WriteLine("Не найдено!");
            }

            Console.ReadKey();
        }
    }
}