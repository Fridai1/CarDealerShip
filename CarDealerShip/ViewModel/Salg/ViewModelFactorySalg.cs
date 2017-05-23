using CarDealerShip.ViewModel.Base;

namespace CarDealerShip
{
    public class ViewModelFactorySalg : ViewModelFactoryBase<Salg>
    {
        
        
            public override DetailsViewModelBase<Salg> CreateDetailsViewModel(Salg obj)
            {
                return new SalgDetailsViewModel(obj);
            }

            public override ItemViewModelBase<Salg> CreateItemViewModel(Salg obj)
            {
                return new SalgItemViewModel(obj);
            }

            public override MasterViewModelBase<Salg> CreateMasterViewModel()
            {
                return new SalgMasterViewModel();
            }

    }
}