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

            string inputFirstLastName;
            string inputPosition;
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
                            AddRecord(out inputFirstLastName, out inputPosition, ref dossierArchive);

                            Console.WriteLine($"\n\nЗапись добавлена.\nДля продолжения нажмите любую кнопку...");
                            Console.ReadKey();
                            break;

                        case CommandViewAllRecords:
                            ViewAllRecords(dossierArchive);

                            Console.WriteLine($"\n\nВыведены все записи.\nДля продолжения нажмите любую кнопку...");
                            Console.ReadKey();
                            break;

                        case CommandDeleteRecord:
                            DeleteRecord(ref dossierArchive);

                            Console.WriteLine($"\n\nЗапись удалена.\nДля продолжения нажмите любую кнопку...");
                            Console.ReadKey();
                            break;

                        case CommandExit:
                            isOpen = false;
                            break;
                    }
                }
            }
        }

        static void AddRecord(out string inputFirstLastName, out string inputPosition, ref Dictionary<string, string> dossierArchive)
        {
            Console.Write("Введите ФИО: ");
            inputFirstLastName = Console.ReadLine();

            Console.Write("Введите должность: ");
            inputPosition = Console.ReadLine();

            dossierArchive.Add(inputFirstLastName, inputPosition);
        }

        static void ViewAllRecords(Dictionary<string, string> dossierArchive)
        {
            foreach (var record in dossierArchive)
            {
                Console.Write("\n" + record.Key + " - " + record.Value);
            }
        }

        static void DeleteRecord(ref Dictionary<string, string> dossierArchive)
        {
            Console.Write("Введите ФИО человека, которого необходимо удалить из досье: ");
            string deleteFirstLastName = Console.ReadLine();

            dossierArchive.Remove(deleteFirstLastName);
        }
    }
}