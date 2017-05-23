using CarDealerShip.ViewModel.Base;

namespace CarDealerShip
    {
        class KundeViewModelFactory : ViewModelFactoryBase<Kunde>
        {
            public override DetailsViewModelBase<Kunde> CreateDetailsViewModel(
                Kunde obj)
            {
                return new KundeDetailsViewModel(obj);

            }

            public override ItemViewModelBase<Kunde> CreateItemViewModel(Kunde obj)
            {
                return new KundeItemViewModel(obj);
            }

            public override MasterViewModelBase<Kunde> CreateMasterViewModel()
            {
                return new KundeMasterViewModel();
            }
        }
    }

