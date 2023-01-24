using System;
using System.Collections.Generic;

namespace _004_PersonnelAccountingPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandAddRecord = "1";
            const string CommandViewAllRecords = "2";
            const string CommandDeleteRecord = "3";
            const string CommandExit = "4";

            bool isOpen = true;

            string inputCommand;

            Dictionary<string, string> dossierArchive = new Dictionary<string, string>();

            Console.SetCursorPosition(0, 0);

            while (isOpen)
            {
                Console.Clear();

                Console.WriteLine(
                        $"{CommandAddRecord} - добавить досье\n" +
                        $"{CommandViewAllRecords} - вывести все досье\n" +
                        $"{CommandDeleteRecord} - удалить досье\n" +
                        $"{CommandExit} - выход\n"
                    );

                Console.Write("Введите команду: ");
                inputCommand = Console.ReadLine();

                if (isOpen)
                {
                    switch (inputCommand)
                    {
                        case CommandAddRecord:
                            AddRecord(dossierArchive);
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

        static void AddRecord(Dictionary<string, string> dossierArchive)
        {
            Console.Write("Введите ФИО: ");
            string inputFirstLastName = Console.ReadLine();

            Console.Write("Введите должность: ");
            string inputPosition = Console.ReadLine();

            if (dossierArchive.ContainsKey(inputFirstLastName) == false)
            {
                dossierArchive.Add(inputFirstLastName, inputPosition);
                Console.WriteLine($"\n\nЗапись добавлена.\nДля продолжения нажмите любую кнопку...");
            }
            else
            {
                Console.WriteLine("Такая запись уже существует.");
            }

            Console.ReadKey();
        }

        static void ViewAllRecords(Dictionary<string, string> dossierArchive)
        {
            foreach (var record in dossierArchive)
                Console.Write("\n" + record.Key + " - " + record.Value);

            Console.WriteLine($"\n\nВыведены все записи.\nДля продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }

        static void DeleteRecord(Dictionary<string, string> dossierArchive)
        {
            Console.Write("Введите ФИО человека, которого необходимо удалить из досье: ");
            string deleteFirstLastName = Console.ReadLine();

            if (dossierArchive.Remove(deleteFirstLastName))
                Console.WriteLine($"\n\nЗапись удалена.\nДля продолжения нажмите любую кнопку...");
            else
                Console.WriteLine("Не найдено!");

            Console.ReadKey();
        }
    }
}