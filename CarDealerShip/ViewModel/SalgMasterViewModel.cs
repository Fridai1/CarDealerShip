using System.Collections.Generic;
using CarDealerShip.DomainLayer;

namespace CarDealerShip
{
    public class SalgMasterViewModel
    {
        public List<SalgItemViewModel> GetSalgItemviewmodelCollection(SalgKatalog katalog)
        {
            List<SalgItemViewModel> items = new List<SalgItemViewModel>();

            foreach (Salg s in katalog.Salgs)
            {
                items.Add(new SalgItemViewModel(s));
            }
            return items;
        }

        public SalgMasterViewModel()
        {

        }
    }
}