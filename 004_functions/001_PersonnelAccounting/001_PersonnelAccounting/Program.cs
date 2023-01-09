using System;

namespace _001_PersonnelAccounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandAdd = "1";
            const string CommandViewAllRecords = "2";
            const string CommandDelete = "3";
            const string CommandFind = "4";
            const string CommandExit = "5";

            string[] personRetrievings = new string[0];
            string[] workingPositions = new string[0];

            string currentCommand;
            string personRetrieving;
            string currentPosition;

            int numberDelRecord;

            bool isExit = false;

            while (isExit == false)
            {
                ViewMenu(CommandAdd, CommandViewAllRecords, CommandDelete, CommandFind, CommandExit);

                Console.Write("Введите команду: ");
                currentCommand = Console.ReadLine();

                if (currentCommand == CommandAdd)
                {
                    InputUserData(out personRetrieving, out currentPosition);
                    AddRecord(ref personRetrievings, ref workingPositions, personRetrieving, currentPosition);
                }
                else if (currentCommand == CommandViewAllRecords)
                {
                    ViewAllRecords(personRetrievings, workingPositions);
                }
                else if (currentCommand == CommandDelete)
                {
                    InputDelNumber(out numberDelRecord);
                    DeleteRecords(ref personRetrievings, ref numberDelRecord);
                    DeleteRecords(ref workingPositions, ref numberDelRecord);
                }
                else if (currentCommand == CommandFind)
                {
                    FindRecordLastname(personRetrievings, workingPositions);
                }
                else if (currentCommand == CommandExit)
                {
                    isExit = true;
                }
            }
        }

        static void ViewMenu(string CommandAdd, string CommandViewAllRecords, string CommandDelete, string CommandFind, string CommandExit)
        {
            Console.WriteLine(
                    "Управление каталогом досье (команды):\n" +
                    $"{CommandAdd}) Добавить досье\n" +
                    $"{CommandViewAllRecords}) Вывести все досье\n" +
                    $"{CommandDelete}) Удалить досье\n" +
                    $"{CommandFind}) Поиск по фамилии\n" +
                    $"{CommandExit}) Выход\n"
                );
        }

        static int InputDelNumber(out int numberDelRecord)
        {
            Console.Write("\nВведите номер записи для удаления из досье: ");
            numberDelRecord = Convert.ToInt32(Console.ReadLine());

            return numberDelRecord;
        }

        static void InputUserData(out string personRetrieving, out string currentPosition)
        {
            Console.Write("\nВведите ФИО: ");
            personRetrieving = Console.ReadLine();

            Console.Write("Введите должность: ");
            currentPosition = Console.ReadLine();
        }

        static string[] EnlargeArray(string[] enlargeStrings)
        {
            string[] tempEnlargeStrings = new string[enlargeStrings.Length + 1];

            for (int i = 0; i < enlargeStrings.Length; i++)
            {
                tempEnlargeStrings[i] = enlargeStrings[i];
            }

            enlargeStrings = tempEnlargeStrings;

            return enlargeStrings;
        }

        static string[] ReducingEntries(string[] reducingString, int numberForDelRecord)
        {
            int countRecord = 0;

            string[] tempPersonRetrievingsBeforeDelRecords = new string[reducingString.Length - 1];

            for (int i = 0; i < reducingString.Length; i++)
            {
                if (numberForDelRecord == i + 1)
                {
                    continue;
                }
                else
                {
                    tempPersonRetrievingsBeforeDelRecords[countRecord] = reducingString[i];

                    countRecord++;
                }
            }

            reducingString = tempPersonRetrievingsBeforeDelRecords;

            return reducingString;
        }

        static string[] Reassignments(string personRetrieving, ref string[] personRetrievings, string[] tempPersonRetrievings)
        {
            tempPersonRetrievings[personRetrievings.Length] = personRetrieving;
            personRetrievings = tempPersonRetrievings;

            return personRetrievings;
        }

        static void AddRecord(ref string[] personRetrievings, ref string[] currentPositions, string personRetrieving, string currentPosition)
        {
            string[] tempPersonRetrievings = EnlargeArray(personRetrievings);
            string[] tempArrayCurrentPositions = EnlargeArray(currentPositions);

            Reassignments(personRetrieving, ref personRetrievings, tempPersonRetrievings);
            Reassignments(currentPosition, ref currentPositions, tempArrayCurrentPositions);

            Console.WriteLine("Запись добавлена!\n");
        }

        static void ViewAllRecords(string[] personRetrievings, string[] workingPositions)
        {
            int countRecord = 1;
            int startIndex;

            Console.WriteLine("\nЗаписи в базе данных\n");

            for (startIndex = 0; startIndex < personRetrievings.Length; startIndex++)
            {
                Console.WriteLine($"| {countRecord} | {personRetrievings[startIndex]} - {workingPositions[startIndex]}");

                countRecord++;
            }

            Console.WriteLine(startIndex == 0 ? "Записи в базе досье отсутствуют!\n" : $"\n...записей в базе: {startIndex}\n");
        }

        static void DeleteRecords(ref string[] personRetrievings, ref int numberDelRecord)
        {
            string[] tempPersonRetrievingsBeforeDelRecords;

            if (numberDelRecord > personRetrievings.Length || numberDelRecord < 1)
            {
                Console.WriteLine("Такой записи нет!\n");
            }
            else if (numberDelRecord == 1 && personRetrievings.Length == 1)
            {
                personRetrievings = new string[0];
            }
            else if (numberDelRecord >= 1 && personRetrievings.Length >= 1)
            {
                tempPersonRetrievingsBeforeDelRecords = ReducingEntries(personRetrievings, numberDelRecord);

                personRetrievings = tempPersonRetrievingsBeforeDelRecords;
            }
        }

        static void FindRecordLastname(string[] personRetrievings, string[] workingPositions)
        {
            string findString;

            string[] tempPersonRetrievings;

            int countIndex = 0;

            Console.Write("Введите фамилию, которую необходимо найти в базе: ");
            findString = Console.ReadLine();

            Console.WriteLine("\nНайдены следующие записи:\n");

            for (int i = 0; i < personRetrievings.Length; i++)
            {
                tempPersonRetrievings = personRetrievings[i].Split(' ');

                if (findString == tempPersonRetrievings[0])
                {
                    Console.WriteLine($"{personRetrievings[i]} - {workingPositions[i]}");

                    countIndex++;
                }
            }

            if (countIndex == 0)
                Console.WriteLine("Записей не найдено!\n");
            else
                Console.WriteLine();
        }
    }
}