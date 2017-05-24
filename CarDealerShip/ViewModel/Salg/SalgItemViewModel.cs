using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarDealerShip.ViewModel.Base;

namespace CarDealerShip
{
    public class SalgItemViewModel : ItemViewModelBase<Salg>
    {

        public override string Description
        {
            get { return DomainObject.getTLF + " med ID " + DomainObject.ID + "has sold made a sale for: " + DomainObject.Price; }
        }

        public override int FontSize
        {
            get { return 24; }
        }

        public SalgItemViewModel(Salg obj) : base(obj)
        {
        }
    }

}