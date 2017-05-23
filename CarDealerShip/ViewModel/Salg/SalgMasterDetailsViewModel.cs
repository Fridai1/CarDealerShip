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
        public SalgMasterDetailsViewModel() : base(new ViewModelFactory(), SalgKatalog.Instance)
        {
            List<string> fixedProperties = new List<string>();
            fixedProperties.Add(nameof(Salg.ID));
            
            List<string> nonFixedKeyProperties = new List<string>();
            nonFixedKeyProperties.Add(nameof(Salg.GetName));
            nonFixedKeyProperties.Add(nameof(Salg.Price));
        }
    }
}