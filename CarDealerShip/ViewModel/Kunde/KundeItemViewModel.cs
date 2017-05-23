using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarDealerShip.Annotations;
using CarDealerShip.ViewModel.Base;

namespace CarDealerShip
{
    public class KundeItemViewModel : ItemViewModelBase<Kunde>
    {

        public override string Description
        {
            get { return DomainObject.Navn + DomainObject.Adresse + DomainObject.Email + DomainObject.TelefonNummer; }
        }

        public override int FontSize
        {
            get { return 24; }
        }

        public KundeItemViewModel(Kunde obj) : base(obj)
        {  
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}