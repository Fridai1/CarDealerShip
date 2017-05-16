using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    public class BilKatalog
    {
        private static BilKatalog _instance = null;
        private List<Bil> _bilkatalog;

        public static BilKatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new BilKatalog();
                return _instance;
            }
        }

        public BilKatalog()
        {
            _bilkatalog = new List<Bil>();
            _instance = this;
        }

        public List<Bil> GetBilKatalog()
        {
            return _bilkatalog;
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
            //test kode
            var test = (from item in _bilkatalog where item.StelNr == bil.StelNr select item).SingleOrDefault();

            if (test != null)
                _bilkatalog.Remove(test);
            //


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
