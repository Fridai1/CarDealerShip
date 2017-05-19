using CarDealerShip.ViewModel.Base;

namespace CarDealerShip
{
    public class ViewModelFactory : ViewModelFactoryBase<Bil>
    {
        public override DetailsViewModelBase<Bil> CreateDetailsViewModel(Bil obj)
        {
            return new BilDetailsViewModel.DetailsViewModel(obj);
        }

        public override ItemViewModelBase<Bil> CreateItemViewModel(Bil obj)
        {
            return new BilItemViewModel(obj);
        }

        public override MasterViewModelBase<Bil> CreateMasterViewModel()
        {
            return new BilMasterViewModel();
        }
    }
}