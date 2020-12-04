using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model
{
    class Player
    {
        public Player(string name, string surname, int skill, string nationality)
        {
            this.name = name;
            this.surname = surname;
            this.skill = skill;
            this.nationality = nationality;
        }

        public string name { get; set; }
        public string surname { get; set; }
        public int skill { get; set; }
        public string nationality { get; set; }
    }
}
