using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarDealerShip.Annotations;
using CarDealerShip.DomainLayer;

namespace CarDealerShip
{
    public class ProvisionItemViewModel : INotifyPropertyChanged
    {
        private Salg _domainobject;
        private Provision _provision;
        

        

        public ProvisionItemViewModel(Salg s)
        {
            _domainobject = s;
           
        }

        

        public int GetId { get { return _domainobject.ID; }  }

        

        public string GetNavn { get { return _domainobject.GetName; } }

       

        public double GetSolgt { get { return _domainobject.Price; } }

        public double GetProv { get { return _provision.GetProv; }  } 



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}