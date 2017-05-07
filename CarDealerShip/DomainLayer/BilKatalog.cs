using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    public class BilKatalog
    {
        private List<Bil> _bilkatalog;

        public BilKatalog()
        {
            _bilkatalog = new List<Bil>();
        }
      
        public Bil GetBil(long stelNr)
        {
            foreach(Bil b in _bilkatalog)
            {
                if (b.StelNr == stelNr)
                {
                    return b;
                }
            }

            return null;
        }

        public void OpretBil(Bil bil)
        {
            _bilkatalog.Add(bil);

        }

        public void DeleteBil(long stelNr)
        {
            foreach(Bil bil in _bilkatalog)
            {
                if (bil.StelNr == stelNr)
                {
                    _bilkatalog.Remove(bil);
                    break;
                }
            }
        }
    }
}
