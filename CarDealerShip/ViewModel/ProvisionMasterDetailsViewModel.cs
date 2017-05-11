using System.Collections.Generic;
using System.Windows.Input;

namespace CarDealerShip
{
    public class ProvisionMasterDetailsViewModel
    {
        private ProvisionItemViewModel _provisionsViewModelSelected;
        private ProvisionMasterViewModel _ProvisionMasterViewModel;
        private RelayCommand _submit;
        private Kunde _a;

        public ProvisionMasterDetailsViewModel(Kunde a)
        {
            _ProvisionMasterViewModel = new ProvisionMasterViewModel();
            _provisionsViewModelSelected = null;
            _submit = new RelayCommand(submit, cansubmit);
            _a = a;
        }

        public ICommand Submitbutton
        {
            get { return _submit; }
        }

        public void submit()
        {
            KundeKatalog.Instance.OpretKunde(_a);
        }

        public bool cansubmit()
        {
            return true;
        }

        //public List<> Type { get; set; }
    }
}