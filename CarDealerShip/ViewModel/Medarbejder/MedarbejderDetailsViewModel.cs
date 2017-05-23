using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealerShip.ViewModel.Base;

namespace CarDealerShip.ViewModel.Medarbejder
{
    class MedarbejderDetailsViewModel : DetailsViewModelBase<CarDealerShip.Medarbejder>
    {
        public MedarbejderDetailsViewModel(CarDealerShip.Medarbejder obj) : base(obj)
        {
        }

        public string Stilling; // er ikke færdig boooo

        public string Navn
        {
            get { return DomainObject.Navn; }
            set { DomainObject.Navn = value; OnPropertyChanged();}
        }

        public string Adresse
        {
            get { return DomainObject.Adresse; }
            set { DomainObject.Adresse = value; OnPropertyChanged(); }
        }

        public long TelefonNummer
        {
            get { return DomainObject.TelefonNummer; }
            set { DomainObject.TelefonNummer = value; OnPropertyChanged();}
        }

        public string Email
        {
            get { return DomainObject.Email; }
            set { DomainObject.Email = value; OnPropertyChanged(); }
        }


    }
}
