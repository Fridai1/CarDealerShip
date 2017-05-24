﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarDealerShip.ViewModel.Base;

namespace CarDealerShip
{
    public class SalgItemViewModel : ItemViewModelBase<Salg>
    {

        public override string Description
        {
            get { return  "sælgeren med ID: " + DomainObject.ID + " har solgt en bil til kunde med tlf nr: " + DomainObject.getTLF + " for: " + DomainObject.Price + " kr." ; }
        }

        public override int FontSize
        {
            get { return 24; }
        }

        public SalgItemViewModel(Salg obj) : base(obj)
        {
        }
    }

}