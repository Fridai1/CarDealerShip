using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using CarDealerShip.Annotations;
using CarDealerShip.ViewModel.Base;

namespace CarDealerShip
{
    public class BilItemViewModel : ItemViewModelBase<Bil>
    {
        
            public override string Description
            {
                get { return DomainObject.StelNr + " from " + DomainObject.Model; }
            }

            public override int FontSize
            {
                get { return 24; }
            }

            public override string ImageSource
            {
                get { return DomainObject.ImageSource; }
            }

            public BilItemViewModel(Bil obj) : base(obj)
                    {
                    }
           
        

        
    }
}
