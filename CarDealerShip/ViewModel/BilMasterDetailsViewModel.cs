using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CarDealerShip.Annotations;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CarDealerShip
{
    public class BilMasterDetailsViewModel : INotifyPropertyChanged
    {
        private BilItemViewModel _bilItemViewModelSelected;
        private BilMasterViewModel _bilMasterViewModel;
        

        public BilMasterDetailsViewModel()
        {
            _bilItemViewModelSelected = null;
            _bilMasterViewModel = new BilMasterViewModel();
            _opretbil = new RelayCommand(opretbil(), altidsand );
        }

        public List<BilItemViewModel> BilItemViewModelCollection
        {
            get { return _bilMasterViewModel.GetBilItemViewModelCollection(BilKatalog.Instance); }
        }

        public BilItemViewModel BilItemViewModelSelected
        {
            get { return _bilItemViewModelSelected; }
        }
        

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void doopret()
        {
            opretbil();
        }
        

        public void opretbil(BilItemViewModel bil)
        {
            BilKatalog.Instance.OpretBil(new Bil(bil.Farve, bil.StelNr, bil.Stand, bil.MotorStr, bil.Type, bil.price, bil.Fabrikant, bil.Model));
        }

        public bool altidsand()
        {
            return true;
        }

        
    }
}
