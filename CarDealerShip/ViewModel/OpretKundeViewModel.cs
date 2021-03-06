﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarDealerShip.Annotations;

namespace CarDealerShip
{
    public class OpretKundeViewModel : INotifyPropertyChanged
    {
        private Kunde _domainobject;

        public OpretKundeViewModel(Kunde k)
        {
            _domainobject = k;
        }

        public string Navn
        {
            get { return _domainobject.Navn; }
            set { _domainobject.Navn = value; }
        }

        public string Adresse
        {
            get { return _domainobject.Addresse;  }
            set { _domainobject.Addresse = value; }
        }

        public string Email
        {
            get { return _domainobject.Email; }
            set { _domainobject.Email = value; }
        }

        public long Telefon
        {
            get { return _domainobject.TelefonNummer; }
            set { _domainobject.TelefonNummer = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}