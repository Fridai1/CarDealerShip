using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarDealerShip.Annotations;
using CarDealerShip.DomainLayer;
using CarDealerShip.ViewModel;

namespace CarDealerShip
{
    public class SalgMasterDetailsViewModel : MasterDetailsViewModelBase<Salg>
    {
        public SalgMasterDetailsViewModel() : base(new ViewModelFactorySalg(), SalgKatalog.Instance)
        {
            List<string> fixedProperties = new List<string>();
            fixedProperties.Add(nameof(Salg.ID));
            
            List<string> nonFixedKeyProperties = new List<string>();
            nonFixedKeyProperties.Add(nameof(Salg.getTLF));
            nonFixedKeyProperties.Add(nameof(Salg.Price));
            nonFixedKeyProperties.Add(nameof(Salg.getStelnummer));
        }

        public List<Bil> BilKatalog
        {
            get {return CarDealerShip.BilKatalog.Instance.All; }
        }

        public List<Kunde> KundeKatalog
        {
            get { return CarDealerShip.KundeKatalog.Instance.All; }
        }

        public List<Medarbejder> MedarbejderKatalog
        {
            get { return CarDealerShip.MedarbejderKatalog.Instance.All; }
        }
    }
}