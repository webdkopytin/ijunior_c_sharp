using System;

namespace _001_PersonnelAccounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CommandAdd = 1;
            int CommandViewAllRecords = 2;
            int CommandDelete = 3;
            int CommandFind = 4;
            int CommandExit = 5;

            int currentCommand;

            bool isExit = false;

            string[] arrayFIO = new string[0];
            string[] arrayCurrentPosition = new string[0];

            while (isExit == false)
            {
                ViewMenu(ref CommandAdd, ref CommandViewAllRecords, ref CommandDelete, ref CommandFind, ref CommandExit);

                Console.Write("Введите команду: ");
                currentCommand = Convert.ToInt32(Console.ReadLine());

                if (currentCommand == CommandAdd)
                    AddRecord(ref arrayFIO, ref arrayCurrentPosition);
                else if (currentCommand == CommandViewAllRecords)
                    ViewAllRecord(ref arrayFIO, ref arrayCurrentPosition);
                else if (currentCommand == CommandDelete)
                    DeleteRecord(ref arrayFIO, ref arrayCurrentPosition);
                else if (currentCommand == CommandFind)
                    FindRecordForLastname(ref arrayFIO, ref arrayCurrentPosition);
                else if (currentCommand == CommandExit)
                    Exit(ref isExit);
            }
        }
        static void ViewMenu(ref int CommandAdd, ref int CommandViewAllRecords, ref int CommandDelete, ref int CommandFind, ref int CommandExit)
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
        static void AddRecord(ref string[] arrayFIO, ref string[] arrayCurrentPosition)
        {
            string[] tempArrayFIO = new string[arrayFIO.Length + 1];
            string[] tempArrayCurrentPosition = new string[arrayCurrentPosition.Length + 1];

            for (int i = 0; i < arrayFIO.Length; i++)
            {
                tempArrayFIO[i] = arrayFIO[i];
                tempArrayCurrentPosition[i] = arrayCurrentPosition[i];
            }

            Console.Write("\nВведите ФИО: ");
            string FIO = Console.ReadLine();

            Console.Write("Введите должность: ");
            string currentPosition = Console.ReadLine();

            tempArrayFIO[arrayFIO.Length] = FIO;
            arrayFIO = tempArrayFIO;

            tempArrayCurrentPosition[arrayCurrentPosition.Length] = currentPosition;
            arrayCurrentPosition = tempArrayCurrentPosition;

            Console.WriteLine("Запись добавлена!\n");
        }
        static void ViewAllRecord(ref string[] arrayFIO, ref string[] arrayCurrentPosition)
        {
            int countRecord = 1;
            int startIndex;

            Console.WriteLine("\nЗаписи в базе данных\n");

            for (startIndex = 0; startIndex < arrayFIO.Length; startIndex++)
            {
                Console.WriteLine($"| {countRecord} | {arrayFIO[startIndex]} - {arrayCurrentPosition[startIndex]}");

                countRecord++;
            }

            Console.WriteLine(startIndex == 0 ? "Записи в базе досье отсутствуют!\n" : $"\n...записей в базе: {startIndex}\n");
        }
        static void DeleteRecord(ref string[] arrayFIO, ref string[] arrayCurrentPosition)
        {
            int numberForDelRecord;
            int countRecord = 0;

            string[] tempArrayFIOBeforeDelRecord;
            string[] tempArrayCPBeforeDelRecord;

            Console.Write("\nВведите номер записи для удаления из досье: ");
            numberForDelRecord = Convert.ToInt32(Console.ReadLine());

            if (numberForDelRecord > arrayFIO.Length || numberForDelRecord < 1)
            {
                Console.WriteLine("Такой записи нет!\n");
            }
            else if (numberForDelRecord == 1 && arrayFIO.Length == 1)
            {
                arrayFIO = new string[0];
                arrayCurrentPosition = new string[0];
            }
            else if (numberForDelRecord >= 1 && arrayFIO.Length >= 1)
            {
                tempArrayFIOBeforeDelRecord = new string[arrayFIO.Length - 1];
                tempArrayCPBeforeDelRecord = new string[arrayCurrentPosition.Length - 1];

                for (int i = 0; i < arrayFIO.Length; i++)
                {
                    if (numberForDelRecord == i + 1)
                    {
                        continue;
                    }
                    else
                    {
                        tempArrayFIOBeforeDelRecord[countRecord] = arrayFIO[i];
                        tempArrayCPBeforeDelRecord[countRecord] = arrayCurrentPosition[i];
                        countRecord++;
                    }
                }

                arrayFIO = tempArrayFIOBeforeDelRecord;
                arrayCurrentPosition = tempArrayCPBeforeDelRecord;
            }
        }
        static void FindRecordForLastname(ref string[] arrayFIO, ref string[] arrayCurrentPosition)
        {
            string findString;

            string[] tempArrayFIO;
            string[] findSuccessArrayFIO = new string[arrayFIO.Length];

            int countIndex = 0;

            Console.Write("Введите фамилию, которую необходимо найти в базе: ");
            findString = Console.ReadLine();

            for (int i = 0; i < arrayFIO.Length; i++)
            {
                tempArrayFIO = arrayFIO[i].Split(' ');

                if (findString == tempArrayFIO[0])
                {
                    findSuccessArrayFIO[countIndex] = arrayFIO[i];

                    countIndex++;
                }
            }

            Console.WriteLine("\nНайдены следующие записи:\n");

            countIndex = 0;

            for (int i = 0; i < findSuccessArrayFIO.Length; i++)
            {
                if (findSuccessArrayFIO[i] == null)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(findSuccessArrayFIO[i]);
                    countIndex++;
                }
            }

            Console.WriteLine();
        }
        static bool Exit(ref bool isExit)
        {
            return isExit = true;
        }
    }
}
