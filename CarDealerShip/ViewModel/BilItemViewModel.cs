using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using CarDealerShip.Annotations;

namespace CarDealerShip
{
    public class BilItemViewModel : INotifyPropertyChanged
    {
        private Bil _domainObject;

        public BilItemViewModel(Bil b)
        {
            _domainObject = b;
        }
        
        public string Stand
        {
            set
            {
                if(value == "Ny")
                {
                    _domainObject.Ny = true;
                }
                else
                {
                    _domainObject.Ny = false;
                }
            }
            get
            {
                if (_domainObject.Ny)
                {
                    return "Ny";
                }
                else
                {
                    return "False";
                }
            }
        }

        public string Type
        {
            set
            {
                _domainObject.Type = value;
            }
            get
            {
                return _domainObject.Type;
            }
        }

        public string Model
        {
            set
            {
                _domainObject.Model = value;
            }
            get
            {
                return _domainObject.Model;
            }
        }

        public string Farve
        {
            set
            {
                _domainObject.Farve = value;
            }
            get
            {
                return _domainObject.Farve;
            }
        }

        public long StelNr
        {
            set
            {
                _domainObject.StelNr = value;
            }
            get
            {
                return _domainObject.StelNr;
            }
        }

        public double MotorStr
        {
            set
            {
                _domainObject.MotorStr = value;
            }
            get
            {
                return _domainObject.MotorStr;
            }
        }


        public string Fabrikant
        {
            set
            {
                _domainObject.Fabrikant = value;
            }
            get
            {
                return _domainObject.Fabrikant;
            }
        }

        public void SubmitCar()
        {
            BilKatalog.Instance.OpretBil(_domainObject);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
