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
                    DeleteRecord();
                else if (currentCommand == CommandFind)
                    FindRecordForLastname();
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

                Console.WriteLine(tempArrayFIO[i]);
            }

            Console.Write("\nВведите ФИО: ");
            string FIO = Console.ReadLine();

            Console.Write("Введите должность: ");
            string currentPosition = Console.ReadLine();

            tempArrayFIO[arrayFIO.Length] = FIO;
            arrayFIO = tempArrayFIO;

            tempArrayCurrentPosition[arrayCurrentPosition.Length] = currentPosition;
            arrayCurrentPosition = tempArrayCurrentPosition;

            Console.WriteLine("Запись добавлена!");
            Console.WriteLine();
        }
        static void ViewAllRecord(ref string[] arrayFIO, ref string[] arrayCurrentPosition)
        {
            int countRecord = 1;

            Console.WriteLine("\nЗаписи в базе данных\n");

            for (int i = 0; i < arrayFIO.Length; i++)
            {
                Console.WriteLine($"{countRecord}) {arrayFIO[i]} - {arrayCurrentPosition[i]}");
                countRecord++;
            }

            Console.WriteLine();
        }
        static void DeleteRecord()
        {
            // TODO: удалить досье(Массивы уменьшаются на один элемент.Нужны дополнительные проверки, чтобы не возникало ошибок)
        }
        static void FindRecordForLastname()
        {
            // TODO: поиск по фамилии
        }
        static bool Exit(ref bool isExit)
        {
            return isExit = true;
        }
    }
}
