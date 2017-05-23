﻿using System.Collections.Generic;

namespace CarDealerShip.ViewModel.Kunde
{
    public class KundeMasterDetailsViewModel : MasterDetailsViewModelBase<CarDealerShip.Kunde>
    {

        public KundeMasterDetailsViewModel() : base(new KundeViewModelFactory(), KundeKatalog.Instance)
        {
            
            

            List<string> fixedProperties = new List<string>();
            // Add names of "fixed" (cannot be changed after creation) properties here
            fixedProperties.Add(nameof(CarDealerShip.Kunde.TelefonNummer));

            List<string> nonFixedKeyProperties = new List<string>();
            // Add names of "non-fixed" (can be changed after creation) properties here
            nonFixedKeyProperties.Add(nameof(CarDealerShip.Kunde.Navn));
            nonFixedKeyProperties.Add(nameof(CarDealerShip.Kunde.Addresse));
            nonFixedKeyProperties.Add(nameof(CarDealerShip.Kunde.Email));
            

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            StateManager.AddButtonDefaultStates();

        }
    }
}
