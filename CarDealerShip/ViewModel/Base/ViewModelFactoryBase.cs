using CarDealerShip.ViewModel.Base;

namespace CarDealerShip
{
    public abstract class ViewModelFactoryBase<TDomainClass>
        where TDomainClass : DomainClassBase
    {
        public abstract DetailsViewModelBase<TDomainClass> CreateDetailsViewModel(TDomainClass obj);
        public abstract ItemViewModelBase<TDomainClass> CreateItemViewModel(TDomainClass obj);
        public abstract MasterViewModelBase<TDomainClass> CreateMasterViewModel();
    }
}