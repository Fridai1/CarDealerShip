using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.AppExtensions;

namespace CarDealerShip 
{
    public class Person : DomainClassBase
    {
        private string _navn;
        private string _adresse;
        private string _email;
        private long _telofonNummer;
        private string _photoID;

        public string Navn  
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public long TelefonNummer
        {
            get { return _telofonNummer; }
            set { _telofonNummer = value; }
        }

        public string PhotoID
        {
            get { return _photoID; }
            set { _photoID = value; }
        }

        public string ImageSource
        {
            get { return AppConfig.ImageFilePrefix + "Domain\\Person\\" + PhotoID + AppConfig.ImageFilePostfix; }
        }

        

        //public Person(string Navn, string Addresse, string Email, long TelefonNummer) //kunde kon
        //{
        //    _navn = Navn;
        //    _addresse = Addresse;
        //    _email = Email;
        //    _telofonNummer = TelefonNummer;
        //}

        

        public override void SetDefaultValues()
        {
            _navn = "Navn";
            _adresse = "Adresse";
            _email = "Email";
            _telofonNummer = 12345678;
            _photoID = "Photo";
        }
    }
}
