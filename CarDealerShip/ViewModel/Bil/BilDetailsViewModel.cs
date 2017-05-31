using Windows.UI.Xaml.Controls;
using CarDealerShip.ViewModel.Base;

namespace CarDealerShip
{
    public class BilDetailsViewModel : DetailsViewModelBase<Bil>
    {
        private ComboBoxItem _standSelected;
        public BilDetailsViewModel(Bil obj) : base(obj)
        {

        }
        public string Stand
            {
            set { DomainObject.Stand = value; }

            get { return DomainObject.Stand; }
                
            }

            public string Type
            {
                set
                {
                    DomainObject.Type = value;
                    OnPropertyChanged();
            }
                get
                {
                    return DomainObject.Type;
                }
            }

            public string Model
            {
                set
                {
                    DomainObject.Model = value;
                    OnPropertyChanged();
            }
                get
                {
                    return DomainObject.Model;
                }
            }

            public string Farve
            {
                set
                {
                    DomainObject.Farve = value;
                    OnPropertyChanged();
            }
                get
                {
                    return DomainObject.Farve;
                }
            }

            public long StelNr
            {
                set
                {
                    DomainObject.StelNr = value;
                    OnPropertyChanged();
            }
                get
                {
                    return DomainObject.StelNr;
                }
            }

            public double MotorStr
            {
                set
                {
                    DomainObject.MotorStr = value;
                    OnPropertyChanged();
            }
                get
                {
                    return DomainObject.MotorStr;
                }
            }


            public string Fabrikant
            {
                set
                {
                    DomainObject.Fabrikant = value;
                    OnPropertyChanged();
            }
                get
                {
                    return DomainObject.Fabrikant;
                }
            }

        public ComboBoxItem StandSelected
        {
            get { return _standSelected; }
            
            set
            {
                DomainObject.Stand = value.ToString();
                _standSelected = value;
                OnPropertyChanged();
            }
        }

        public string Stand
        {
            get { return DomainObject.Stand; }
            
        }

            
        }
    }
