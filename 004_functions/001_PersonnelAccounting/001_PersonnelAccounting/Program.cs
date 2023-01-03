using System;

namespace _001_PersonnelAccounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CommandAdd = 1;
            const int CommandViewAllRecords = 2;
            const int CommandDelete = 3;
            const int CommandFind = 4;
            const int CommandExit = 5;

            int currentCommand;
            int numberDelRecord;

            bool isExit = false;

            string[] personRetrievings = new string[0];
            string[] workingPositions = new string[0];

            while (isExit == false)
            {
                ViewMenu(CommandAdd, CommandViewAllRecords, CommandDelete, CommandFind, CommandExit);

                Console.Write("Введите команду: ");
                currentCommand = Convert.ToInt32(Console.ReadLine());

                if (currentCommand == CommandAdd)
                    AddRecord(ref personRetrievings, ref workingPositions);
                else if (currentCommand == CommandViewAllRecords)
                    ViewAllRecords(personRetrievings, workingPositions);
                else if (currentCommand == CommandDelete)
                {
                    Console.Write("\nВведите номер записи для удаления из досье: ");
                    numberDelRecord = Convert.ToInt32(Console.ReadLine());

                    DeleteRecords(ref personRetrievings, ref numberDelRecord);
                    DeleteRecords(ref workingPositions, ref numberDelRecord);
                }
                else if (currentCommand == CommandFind)
                    FindRecordLastname(personRetrievings, workingPositions);
                else if (currentCommand == CommandExit)
                    isExit = true;
            }
        }

        static void ViewMenu(int CommandAdd, int CommandViewAllRecords, int CommandDelete, int CommandFind, int CommandExit)
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

        static void AddRecord(ref string[] personRetrievings, ref string[] currentPositions)
        {
            string[] tempPersonRetrievings = EnlargeArray(personRetrievings);
            string[] tempArrayCurrentPositions = EnlargeArray(currentPositions);

            Console.Write("\nВведите ФИО: ");
            string personRetrieving = Console.ReadLine();

            Console.Write("Введите должность: ");
            string currentPosition = Console.ReadLine();

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