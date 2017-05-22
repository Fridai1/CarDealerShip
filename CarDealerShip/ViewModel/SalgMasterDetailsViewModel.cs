using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarDealerShip.Annotations;
using CarDealerShip.DomainLayer;

namespace CarDealerShip
{
    public class SalgMasterDetailsViewModel
    {
        private SalgItemViewModel _salgItemViewModelSelected;
        private SalgMasterViewModel _salgMasterViewModel;



        public SalgMasterDetailsViewModel()
        {
            _salgMasterViewModel = new SalgMasterViewModel();



        }

        public List<SalgItemViewModel> GetSalgItemviewmodelCollection
        {
            get { return _salgMasterViewModel.GetSalgItemviewmodelCollection(SalgKatalog.Instance); }
        }

        public SalgItemViewModel SalgItemViewModelSelected
        {
            get { return _salgItemViewModelSelected; }
            set
            {
                _salgItemViewModelSelected = value;
                OnPropertyChanged();
            }
        }









        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}