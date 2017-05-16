using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CarDealerShip.ViewModel
{
    public class KundeItemViewModel : INotifyPropertyChanged
    {
        private Kunde _domainobject;

        public KundeItemViewModel(Kunde k)
        {
            _domainobject = k;
        }

        public string Navn
        {
            get { return _domainobject.Navn; }
        }

        public string Adresse
        {
            get { return _domainobject.Addresse; }
        }

        public string Email
        {
            get { return _domainobject.Email; }
            
        }

        public long Telefon
        {
            get { return _domainobject.TelefonNummer; }
            
        }

        public void SubmitKunde()
        {
            KundeKatalog.Instance.OpretKunde(_domainobject);
        }

       public event PropertyChangedEventHandler PropertyChanged;

        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}