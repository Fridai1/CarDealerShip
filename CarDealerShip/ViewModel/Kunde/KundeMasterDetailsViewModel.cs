using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CarDealerShip.Annotations;

namespace CarDealerShip.ViewModel
{
    public class KundeMasterDetailsViewModel : INotifyPropertyChanged
    {
        private KundeItemViewModel _kundeItemViewModelSelected;
        private KundeMasterViewModel _kundeMasterViewModel;



        public KundeMasterDetailsViewModel()
        {
            _kundeMasterViewModel = new KundeMasterViewModel();
            _kundeItemViewModelSelected = null; 
            
            
            
        }

        public List<KundeItemViewModel> KundeItemViewModelCollection
        {
            get { return _kundeMasterViewModel.GetOpretKundeviewmodelCollection(KundeKatalog.Instance); }
        }

        public KundeItemViewModel KundeItemViewModelSelected
        {
            get { return _kundeItemViewModelSelected; }
            set
            {
                _kundeItemViewModelSelected = value;
                OnPropertyChanged();
            }
        }

        //public void SubmitKunde()
        //{
        //    KundeKatalog.Instance.OpretKunde(_domainobject);
        //}

        //private void submit(KundeItemViewModel k)
        //{
        //    KundeKatalog.Instance.OpretKunde(new Kunde(k.Navn, k.Adresse, k.Email, k.Telefon));
        //}

        


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
