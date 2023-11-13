using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_21._10_Pytymko_V.L
{
//    Створіть клас «Футбольна Команда». Клас має містити
//інформацію про гравців футбольної команди.Реалізуйте
//підтримку ітератора для класу «Футбольна Команда».
//Протестуйте можливість використання foreach для класу
//«Футбольна Команда».
    public class Player 
    {
        public string _Name { get; set; }
        public string _Position { get; set; }
        public int _Number { get; set; }

        public Player(string name, string position, int number)
        {
            _Name = name;
            _Position = position;
            _Number = number;
        }
    }



    public class FC: IEnumerable<Player>
    {private List<Player> _Players;
        public FC()
        {
            _Players = new List<Player>();
        }

        public void AddPlayers(string name,string position, int number)
        {
            Player _Player= new Player(name,position,number);
            _Players.Add(_Player);
        }
        public IEnumerator<Player> GetEnumerator()
        {
            foreach (var _Player in _Players)
            {
                yield return _Player;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }

}
