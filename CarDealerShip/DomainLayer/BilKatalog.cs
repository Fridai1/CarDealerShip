using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    public class BilKatalog
    {
        private Dictionary<long, Bil> _BilKatalog;

        public BilKatalog()
        {
            _BilKatalog = new Dictionary<long, Bil>();
        }
      

        public void OpretBil(Bil bil)
        {
            BilKatalog.Add(bil.StelNr, bil);
        }

        public void DeleteBil(int StelNr)
        {
            BilKatalog.Remove(StelNr);
        }
    }
}
