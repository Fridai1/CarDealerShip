using System.Collections.Generic;
using CarDealerShip.DomainLayer;

namespace CarDealerShip
{
    public class SalgMasterViewModel
    {
        public List<SalgViewModel> GetSalgItemviewmodelCollection(SalgKatalog katalog)
        {
            List<SalgViewModel> items = new List<SalgViewModel>();

            foreach (Salg s in katalog.Salgs)
            {
                items.Add(new SalgViewModel(s));
            }
            return items;
        }

        public SalgMasterViewModel()
        {

        }
    }
}