using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealerShip.ViewModel.Base;

namespace CarDealerShip.ViewModel.Medarbejder
{
    class MedarbejderViewModelFactory : ViewModelFactoryBase<CarDealerShip.Medarbejder>
    {
        public override DetailsViewModelBase<CarDealerShip.Medarbejder> CreateDetailsViewModel(
            CarDealerShip.Medarbejder obj)
        {
            return new MedarbejderDetailsViewModel(obj);
            
        }

        public override ItemViewModelBase<CarDealerShip.Medarbejder> CreateItemViewModel(CarDealerShip.Medarbejder obj)
        {
            return new MedarbejderItemViewModel(obj);
        }

        public override MasterViewModelBase<CarDealerShip.Medarbejder> CreateMasterViewModel()
        {
            return new MedarbejderMasterViewModel();
        }
    }
}
