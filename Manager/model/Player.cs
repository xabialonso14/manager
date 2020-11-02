using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model
{
    class Player
    {
        public Player(string imię, string nazwisko, int umiejętność, string narodowość)
        {
            this.imię = imię;
            this.nazwisko = nazwisko;
            this.umiejętność = umiejętność;
            this.narodowość = narodowość;
        }

        public string imię { get; set; }
        public string nazwisko { get; set; }
        public int umiejętność { get; set; }
        public string narodowość { get; set; }
    }
}
