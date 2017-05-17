using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarDealerShip.Annotations;
using CarDealerShip.DomainLayer;

namespace CarDealerShip
{
    public class SalgMasterDetailsViewModel
    {
        private SalgViewModel _SalgItemViewModelSelected;
        private SalgMasterViewModel _SalgMasterViewModel;



        public SalgMasterDetailsViewModel()
        {
            _SalgMasterViewModel = new SalgMasterViewModel();



        }

        public List<SalgViewModel> GetSalgItemviewmodelCollection
        {
            get { return _SalgMasterViewModel.GetSalgItemviewmodelCollection(SalgKatalog.Instance); }
        }

        public SalgViewModel SalgItemViewModelSelected
        {
            get { return _SalgItemViewModelSelected; }
            set
            {
                _SalgItemViewModelSelected = value;
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