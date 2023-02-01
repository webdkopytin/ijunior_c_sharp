using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_DataBasePlayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание самой БД не требуется, задание выполняется инструментами, которые вы уже изучили в рамках курса. Но нужен класс, который
            // содержит игроков и её можно назвать "База данных".
        }

        class Player
        {
            private int _id;
            private string _name;
            private bool _isBanned;

            public Player(int id, string name, bool isBanned)
            {
                _id = id;
                _name = name;
                _isBanned = isBanned;
            }

            /// <summary>
            /// Добавляет игрока
            /// </summary>
            public void AddUser()
            {

            }

            /// <summary>
            /// Банит игрока по уникальному номеру
            /// </summary>
            public void SetBanUser ()
            {

            }

            /// <summary>
            /// Снимает Бан с игрока по уникальному номеру
            /// </summary>
            public void UnBanUser()
            {

            }

            /// <summary>
            /// Удаляет игрока
            /// </summary>
            public void DelUser()
            {

            }
        }
    }
}
