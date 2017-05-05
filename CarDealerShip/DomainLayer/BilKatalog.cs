using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    static class BilKatalog
    {
        static Dictionary<int, Bil> Katalog = new Dictionary<int, Bil>();

        static void OpretBil(Bil bil)
        {
            Katalog.Add(bil.StelNr, bil);
        }

        static void DeleteBil(int StelNr)
        {
            Katalog.Remove(StelNr);
        }
    }
}
