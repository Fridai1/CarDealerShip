using CarDealerShip.ViewModel.Base;

namespace CarDealerShip.ViewModel.Kunde
    {
        class KundeViewModelFactory : ViewModelFactoryBase<CarDealerShip.Kunde>
        {
            public override DetailsViewModelBase<CarDealerShip.Kunde> CreateDetailsViewModel(
                CarDealerShip.Kunde obj)
            {
                return new KundeDetailsViewModel(obj);

            }

            public override ItemViewModelBase<CarDealerShip.Kunde> CreateItemViewModel(CarDealerShip.Kunde obj)
            {
                return new KundeItemViewModel(obj);
            }

            public override MasterViewModelBase<CarDealerShip.Kunde> CreateMasterViewModel()
            {
                return new KundeMasterViewModel();
            }
        }
    }

