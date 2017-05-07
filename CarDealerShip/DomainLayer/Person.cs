using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip 
{
    class Person
    {
        private string _navn;
        private string _addresse;
        private string _email;
        private long _telofonNummer;

        public string Navn  
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Addresse
        {
            get { return _addresse; }
            set { Addresse = value; }
        }

        public string Email
        {
            get { return _email; }
            set { Email = value; }
        }

        public long TelefonNummer
        {
            get { return _telofonNummer; }
            set { _telofonNummer = value; }
        }

        public Person(string Navn) //ansat konstrokter 
        {
            _navn = Navn;
        }

        public Person(string Navn, string Addresse, string Email, long TelefonNummer) //kunde kon
        {
            _navn = Navn;
            _addresse = Addresse;
            _email = Email;
            _telofonNummer = TelefonNummer;
        }
    }
}
