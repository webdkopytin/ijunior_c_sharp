using System;

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

                if (isCommand && parseCommand == CommandExit)
                    isOpen = false;

                if (isCommand && isOpen)
                {
                    switch (parseCommand)
                    {
                        case CommandAddRecord:
                            AddRecord(out inputFirstLastName, out inputPosition);
                            break;

                        case CommandViewAllRecords:
                            ViewAllRecords();
                            break;

                        case CommandDeleteRecord:
                            DeleteRecord();
                            break;
                    }
                }
            }
        }

        static void AddRecord(out string inputFirstLastName, out string inputPosition)
        {
            Console.WriteLine("Введите ФИО: ");
            inputFirstLastName = Console.ReadLine();

            Console.WriteLine("Введите должность: ");
            inputPosition = Console.ReadLine();
        }

        static void ViewAllRecords()
        {

        }

        static void DeleteRecord()
        {

        }
    }
}
