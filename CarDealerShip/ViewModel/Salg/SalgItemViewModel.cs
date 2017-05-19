using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CarDealerShip
{
    public class SalgItemViewModel : INotifyPropertyChanged
    {
        private Salg _domainobject;

        public SalgItemViewModel(Salg s)
        {
            _domainobject = s;
        }

        public int ID
        {
            get { return _domainobject.ID; }
        }

        public double Price
        {
            get { return _domainobject.Price; }
        }

       
        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}