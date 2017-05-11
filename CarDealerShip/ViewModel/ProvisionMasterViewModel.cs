using System.Collections.Generic;
using System.Threading;
using CarDealerShip.DomainLayer;

namespace CarDealerShip
{
    public class ProvisionMasterViewModel
    {
        public List<ProvisionItemViewModel> GetProvisionitemviewmodelCollection()
        {
            List<ProvisionItemViewModel> items = new List<ProvisionItemViewModel>();

            foreach (Salg s in SalgKatalog.Salgs)
            {
                items.Add(new ProvisionItemViewModel(s));
            }
          return items;
        }

        public ProvisionMasterViewModel()
        {
            
        }
    }
}