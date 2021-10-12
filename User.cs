using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dflat
{
    public class User
    {
        public static int _id;
        private static int _counter;
        private string _etunimi;
        private string _sukunimi;
        private string _valittupalvelu;
        private string _valittuaika;

        public string etunimi
        {
            get => _etunimi;
            set => _etunimi = value;
        }

        public string sukunimi
        {
            get => _sukunimi;
            set => _sukunimi = value;
        }

        public string valittupalvelu
        {
            get => _valittupalvelu;
            set => _valittupalvelu = value;
        }

        public string valittuaika
        {
            get => _valittuaika;
            set => _valittuaika = value;
        }

        public static int Counter => _counter;

        public User()
        {
            _counter = ++_id; // Laske käyttäjän paikkaa listassa
        }
    }
}
