using System.Collections.Generic;
using System.Linq;

namespace CarDealerShip.DomainLayer
{
    public static class SalgKatalog
    {
        private static List<Salg> _salgKatalog;

        static SalgKatalog()
        {
            _salgKatalog = new List<Salg>();
        }

        public static List<Salg> Salgs { get { return _salgKatalog.ToList(); } }

        public static double GetTotalSalg(int id)
        {
            int i = 0;
            double value = 0;

            while (i < _salgKatalog.Count)
            {
                if (_salgKatalog[i].ID == id)
                {
                    double plus = _salgKatalog[i].Price;
                    value = plus + value;
                }
                i++;
            }
            return value;
        }



        public static int GetIdSalg(int id)
        {
            int i = 0;

            while (i < _salgKatalog.Count)
            {
                if (_salgKatalog[i].ID == id)
                {
                    return _salgKatalog[i].ID;
                }
                i++;
            }
            return 0;
        }


        public static void OpretSalg(Salg salg)
        {
            _salgKatalog.Add(salg);

        }
    }
}