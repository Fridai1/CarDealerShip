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
    public class BilViewModel : INotifyPropertyChanged
    {
        private bool _stand;
        private string _type;
        private string _model;
        private string _fabrikant;
        private string _farve;
        private long _stelNr;
        private double _motorStr;

        public IEnumerable<string> SetStand
        {
            set
            {
                if(value.ToString() == "Ny")
                {
                    _stand = true;
                }
                else
                {
                    _stand = false;
                }
            }
        }

        public IEnumerable<string> SetType
        {
            set
            {
                _type = value.ToString();
            }
        }

        public string SetModel
        {
            set
            {
                _model = value;
            }
        }

        public string SetFarve
        {
            set
            {
                _farve = value;
            }
        }
        public long SetStelNr
        {
            set
            {
                _stelNr = value;
            }
        }

        public double SetMotorStr
        {
            set
            {
                _motorStr = value;
            }
        }


        public string SetFabrikant
        {
            set
            {
                _fabrikant = value;
            }
        }

        public void SubmitCar()
        {
            BilKatalog.Instance.OpretBil(new Bil(_farve, _stelNr, _stand, _motorStr, _type, 0, _fabrikant, _model));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
