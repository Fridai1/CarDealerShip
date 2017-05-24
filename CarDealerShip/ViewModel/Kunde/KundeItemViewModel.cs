using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarDealerShip.ViewModel.Base;
using CarDealerShip;

namespace CarDealerShip.ViewModel.Kunde
{
    public class KundeItemViewModel : ItemViewModelBase<CarDealerShip.Kunde>
    {

        public override string Description
        {
            get { return DomainObject.Navn + DomainObject.Adresse + DomainObject.Email + DomainObject.TelefonNummer; }
        }

        public override int FontSize
        {
            get { return 24; }
        }

        public KundeItemViewModel(CarDealerShip.Kunde obj) : base(obj)
        {  
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}