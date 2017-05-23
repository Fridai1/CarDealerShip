using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CarDealerShip.Annotations;
using CarDealerShip.ViewModel;


namespace CarDealerShip
{
    public class KundeMasterDetailsViewModel : MasterDetailsViewModelBase<Kunde>
    {

        public KundeMasterDetailsViewModel() : base(new KundeViewModelFactory(), KundeKatalog.Instance)
        {
            
            

            List<string> fixedProperties = new List<string>();
            // Add names of "fixed" (cannot be changed after creation) properties here
            fixedProperties.Add(nameof(Kunde.TelefonNummer));

            List<string> nonFixedKeyProperties = new List<string>();
            // Add names of "non-fixed" (can be changed after creation) properties here
            nonFixedKeyProperties.Add(nameof(Kunde.Navn));
            nonFixedKeyProperties.Add(nameof(Kunde.Addresse));
            nonFixedKeyProperties.Add(nameof(Kunde.Email));
            

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            StateManager.AddButtonDefaultStates();

        }
    }
}
