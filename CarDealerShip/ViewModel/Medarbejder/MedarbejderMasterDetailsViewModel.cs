using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip.ViewModel.Medarbejder
{
    public class MedarbejderMasterDetailsViewModel : MasterDetailsViewModelBase<CarDealerShip.Medarbejder>
    {
        public MedarbejderMasterDetailsViewModel() : base(new MedarbejderViewModelFactory(), MedarbejderKatalog.Instance)
            {
               
                List<string> fixedProperties = new List<string>();
               
                fixedProperties.Add(nameof(CarDealerShip.Medarbejder.Id));

                List<string> nonFixedKeyProperties = new List<string>();
                
                nonFixedKeyProperties.Add(nameof(CarDealerShip.Medarbejder.Navn));
                nonFixedKeyProperties.Add(nameof(CarDealerShip.Medarbejder.Adresse));
                nonFixedKeyProperties.Add(nameof(CarDealerShip.Medarbejder.Email));
                nonFixedKeyProperties.Add(nameof(CarDealerShip.Medarbejder.TelefonNummer));
            //nonFixedKeyProperties.Add(nameof(CarDealerShip.Medarbejder.Chef));



            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
                StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
                StateManager.AddButtonDefaultStates();
            
            }
    }
    
}
