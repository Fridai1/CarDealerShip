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
            get { return DomainObject.Navn + DomainObject.Addresse + DomainObject.Email + DomainObject.TelefonNummer; }
        }

        public override int FontSize
        {
            get { return 24; }
        }

        public KundeItemViewModel(Kunde obj) : base(obj)
        {
        }
    }
}