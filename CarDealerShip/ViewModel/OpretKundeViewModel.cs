using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarDealerShip.Annotations;

namespace CarDealerShip
{
    public class OpretKundeViewModel : INotifyPropertyChanged
    {
        private Kunde _domainobject;


        public OpretKundeViewModel(Kunde k)
        {
            _domainobject = k;
            
        }

        public string Navn
        {
            get { return _domainobject.Navn; }
            set { _domainobject.Navn = value; }
        }

       

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}