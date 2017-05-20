using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CarDealerShip.Annotations;
using System.Runtime.CompilerServices;
using CarDealerShip.ViewModel;

namespace CarDealerShip
{
    public class BilMasterDetailsViewModel : MasterDetailsViewModelBase<Bil>
    {
        //private BilItemViewModel _bilItemViewModelSelected;
        //private BilMasterViewModel _bilMasterViewModel;
        

        public BilMasterDetailsViewModel() : base(new ViewModelFactory(), BilKatalog.Instance)
        {
            //_bilItemViewModelSelected = null;
            //_bilMasterViewModel = new BilMasterViewModel();

            List<string> fixedProperties = new List<string>();
            // Add names of "fixed" (cannot be changed after creation) properties here
            fixedProperties.Add(nameof(Bil.StelNr));

            List<string> nonFixedKeyProperties = new List<string>();
            // Add names of "non-fixed" (can be changed after creation) properties here
            nonFixedKeyProperties.Add(nameof(Bil.Farve));
            nonFixedKeyProperties.Add(nameof(Bil.Fabrikant));
            nonFixedKeyProperties.Add(nameof(Bil.Model));
            nonFixedKeyProperties.Add(nameof(Bil.MotorStr));
            nonFixedKeyProperties.Add(nameof(Bil.Price));
            nonFixedKeyProperties.Add(nameof(Bil.Ny));
            nonFixedKeyProperties.Add(nameof(Bil.Type));
           

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            StateManager.AddButtonDefaultStates();

            //StateManager.AddViewControlState(new ViewControlState("ZipCodeFilter", "ZipCode below 3000"));
            //StateManager.AddViewControlState(new ViewControlState("BornFilter", "Born after 1990"));
        }

        //public List<BilItemViewModel> BilItemViewModelCollection
        //{
        //    get { return _bilMasterViewModel.GetBilItemViewModelCollection(BilKatalog.Instance); }
        //}


       
        

       
    }
}
