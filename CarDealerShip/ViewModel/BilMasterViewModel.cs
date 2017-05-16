using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CarDealerShip
{
    public class BilMasterViewModel
    {
        public BilMasterViewModel()
        {
        }

        public List<BilItemViewModel> GetBilItemViewModelCollection(BilKatalog katalog)
        {
            List<BilItemViewModel> items = new List<BilItemViewModel>();

            foreach (Bil b in katalog.GetBilKatalog())
            {
                items.Add(new BilItemViewModel(b));
            }

            return items;
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
