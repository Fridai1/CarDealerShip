using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip.ViewModel.Medarbejder
{
    public class MedarbejderMasterDetailsViewModel : MasterDetailsViewModelBase<CarDealerShip.Medarbejder>
    {
        public MedarbejderMasterDetailsViewModel() : base(new MedarbejderViewModelFactory(),
            MedarbejderKatalog.Instance)
        {
            public MedarbejderMasterDetailsViewModel() : base(new ViewModelFactory(), Medarbejderkatalog.Instance)
            {
               
                List<string> fixedProperties = new List<string>();
               
                fixedProperties.Add(nameof(Medarbejder.StelNr));

                List<string> nonFixedKeyProperties = new List<string>();
                
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
    }
    }
}
