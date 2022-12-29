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

            string[] arrayFIO;
            string[] arrayCurrentPosition;

            while (isExit == false)
            {
                ViewMenu(ref CommandAdd, ref CommandViewAllRecords, ref CommandDelete, ref CommandFind, ref CommandExit);

                Console.Write("Введите команду: ");
                currentCommand = Convert.ToInt32(Console.ReadLine());

                if (currentCommand == CommandAdd)
                    AddRecord();
                else if (currentCommand == CommandViewAllRecords)
                    ViewAllRecord();
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
        static void AddRecord()
        {
            // TODO: добавить досье
        }
        static void ViewAllRecord()
        {
            // TODO: вывести все досье(в одну строку через “-” фио и должность с порядковым номером в начале)
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
