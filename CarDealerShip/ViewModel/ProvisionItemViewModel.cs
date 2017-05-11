using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarDealerShip.Annotations;
using CarDealerShip.DomainLayer;

namespace CarDealerShip
{
    public class ProvisionItemViewModel : INotifyPropertyChanged
    {
        private Provision _domainObject;
        
        

        public ProvisionItemViewModel(Provision p)
        {
            _domainObject = p;
  
        }

        public int id => _domainObject.getID;

        public double TotalSolgt => _domainObject.GetTotalSolgt;

        public double Provision => _domainObject.Getprovision;


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}