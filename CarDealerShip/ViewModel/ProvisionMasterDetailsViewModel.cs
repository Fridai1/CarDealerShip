using System.Collections.Generic;
using System.Windows.Input;

namespace CarDealerShip
{
    public class ProvisionMasterDetailsViewModel
    {
        private ProvisionItemViewModel _provisionsViewModelSelected;
        private ProvisionMasterViewModel _ProvisionMasterViewModel;
        private RelayCommand _submit;
        

        public ProvisionMasterDetailsViewModel(Kunde a)
        {
            _ProvisionMasterViewModel = new ProvisionMasterViewModel();
            _provisionsViewModelSelected = null;
        }

        

        //public List<> Type { get; set; }
    }
}