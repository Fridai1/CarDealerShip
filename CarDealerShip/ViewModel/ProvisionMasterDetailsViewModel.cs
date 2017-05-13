using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CarDealerShip.Annotations;
using CarDealerShip.DomainLayer;

namespace CarDealerShip
{
    public class ProvisionMasterDetailsViewModel : INotifyPropertyChanged
    {
        private ProvisionItemViewModel _provisionitemViewModelSelected;
        private ProvisionMasterViewModel _ProvisionMasterViewModel;
        
        

        public ProvisionMasterDetailsViewModel()
        {
            _ProvisionMasterViewModel = new ProvisionMasterViewModel();
            _provisionitemViewModelSelected = null;

        }

        public List<ProvisionItemViewModel> ProvisionItemViewModelCollection
        {
            get { return _ProvisionMasterViewModel.GetProvisionitemviewmodelCollection(SalgKatalog.Instance); }
        }

        public ProvisionItemViewModel ProvisionItemViewModelSelected
        {
            get { return _provisionitemViewModelSelected; }
        }

        
        

        
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}