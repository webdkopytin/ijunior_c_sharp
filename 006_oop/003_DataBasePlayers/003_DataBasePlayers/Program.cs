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
            
        }

        class DataBasePlayers
        {
            /// <summary>
            /// Добавляет игрока
            /// </summary>
            public void AddPlayer()
            {

            }

            /// <summary>
            /// Удаляет игрока
            /// </summary>
            public void DeletePlayer()
            {

            }
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
            /// Банит игрока по уникальному номеру
            /// </summary>
            public void SetBanPlayer()
            {

            }

            /// <summary>
            /// Снимает Бан с игрока по уникальному номеру
            /// </summary>
            public void UnBanPlayer()
            {

            }
        }
    }
}
