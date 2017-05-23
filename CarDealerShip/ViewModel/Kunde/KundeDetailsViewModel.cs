using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarDealerShip.ViewModel.Base;

namespace CarDealerShip
{
    public class KundeDetailsViewModel : DetailsViewModelBase<Kunde>
    {
        public KundeDetailsViewModel(Kunde obj) : base(obj)
        {
        }

        public string Navn
        {
            set
            {
                DomainObject.Navn = value;
                OnPropertyChanged();
            }
            get { return DomainObject.Navn; }
        }

        public string Addresse
        {
            set
            {
                DomainObject.Adresse = value;
                OnPropertyChanged();
            }
            get { return DomainObject.Adresse; }
        }

        public string Email
        {
            set
            {
                DomainObject.Email = value;
                OnPropertyChanged();
            }
            get { return DomainObject.Email; }
        }

        public long Telefon
        {
            set
            {
                DomainObject.TelefonNummer = value;
                OnPropertyChanged();
            }
            get { return DomainObject.TelefonNummer; }
        }
    }
}