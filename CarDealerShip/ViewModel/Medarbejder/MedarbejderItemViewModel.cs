using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealerShip.ViewModel.Base;

namespace CarDealerShip.ViewModel.Medarbejder
{
    class MedarbejderItemViewModel : ItemViewModelBase<CarDealerShip.Medarbejder>
    {
        public override string Description
        {
            get { return DomainObject.Chef + " " + DomainObject.Navn; }
        }

        public override int FontSize
        {
            get { return 24; }
        }

    public MedarbejderItemViewModel(CarDealerShip.Medarbejder obj) : base(obj)
        {
        }
    }
}
