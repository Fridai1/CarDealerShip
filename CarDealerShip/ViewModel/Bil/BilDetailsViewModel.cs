using CarDealerShip.ViewModel.Base;

namespace CarDealerShip
{
    public class BilDetailsViewModel
    {
        public class DetailsViewModel : DetailsViewModelBase<Bil>
        {
            public string Stand
            {
                set
                {
                    if (value == "Ny")
                    {
                        DomainObject.Ny = true;
                    }
                    else
                    {
                        DomainObject.Ny = false;
                    }
                }
                get
                {
                    if (DomainObject.Ny)
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
                    DomainObject.Type = value;
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
                }
                get
                {
                    return DomainObject.Fabrikant;
                }
            }

            public DetailsViewModel(Bil obj) : base(obj)
            {
            }
        }
    }
}