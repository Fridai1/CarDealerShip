using System.Collections.ObjectModel;

namespace CarDealerShip.ViewModel.Base
{
    public abstract class MasterViewModelBase<TDomainClass>
        where TDomainClass : DomainClassBase
    {
        private ObservableCollection<ItemViewModelBase<TDomainClass>> _itemViewModelCollection;

        public virtual ObservableCollection<ItemViewModelBase<TDomainClass>> CreateItemViewModelCollection(
            CatalogBase<TDomainClass> catalog,
            ViewModelFactoryBase<TDomainClass> factory)
        {
            _itemViewModelCollection.Clear();

            foreach (TDomainClass obj in catalog.All)
            {
                _itemViewModelCollection.Add(factory.CreateItemViewModel(obj));
            }

            return _itemViewModelCollection;
        }

        protected MasterViewModelBase()
        {
            _itemViewModelCollection = new ObservableCollection<ItemViewModelBase<TDomainClass>>();
        }
    }
}