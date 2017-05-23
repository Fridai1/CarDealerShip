using CarDealerShip.ViewModel.Base;

namespace CarDealerShip.ViewModel.Kunde
{
    public class KundeDetailsViewModel : DetailsViewModelBase<CarDealerShip.Kunde>
    {
        public KundeDetailsViewModel(CarDealerShip.Kunde obj) : base(obj)
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