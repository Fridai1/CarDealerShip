using System.Collections.Generic;

namespace CarDealerShip.ViewModel
{
    public class KundeMasterViewModel
    {
        public List<KundeItemViewModel> GetOpretKundeviewmodelCollection(KundeKatalog katalog)
        {
            List<KundeItemViewModel> items = new List<KundeItemViewModel>();

            foreach (Kunde k in katalog.GetKunde()) 
            {
                items.Add(new KundeItemViewModel(k));
            }
            return items;
        }
    }
}