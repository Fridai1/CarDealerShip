using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarDealerShip.Annotations;
using CarDealerShip.DomainLayer;

namespace CarDealerShip
{
    public class ProvisionItemViewModel : INotifyPropertyChanged
    {
        private Salg _domainobject;
        //private Provision _domainObject;

        public ProvisionItemViewModel(Salg s)
        {
            _domainobject = s;
        }

        //public ProvisionItemViewModel(Provision p)
        //{
        //    _domainObject = p;
  
        //}

        public int GetId { get { return _domainobject.ID; }  }

        //public int Getid => _domainObject.getID;



        //public double TotalSolgt => _domainObject.GetTotalSolgt;

        //public double Provision => _domainObject.GetProv;


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}