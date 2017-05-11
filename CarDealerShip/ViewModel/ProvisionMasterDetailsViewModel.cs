using System.Collections.Generic;

namespace CarDealerShip
{
    public class ProvisionMasterDetailsViewModel
    {
        private ProvisionItemViewModel _provisionsViewModelSelected;
        private ProvisionMasterViewModel _ProvisionMasterViewModel;

        public ProvisionMasterDetailsViewModel()
        {
            _ProvisionMasterViewModel = new ProvisionMasterViewModel();
            _provisionsViewModelSelected = null;
        }

        //public List<> Type { get; set; }
    }
}