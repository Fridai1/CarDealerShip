using System.Collections.Generic;

namespace CarDealerShip.DomainLayer
{
    public static class SalgKatalog
    {
        private static List<Salg> _salgKatalog;

        static SalgKatalog()
        {
            _salgKatalog = new List<Salg>();
        }

        public static Salg GetSalg(int id)
        {
            int i = 0;

            while (i < _salgKatalog.Count)
            {
                if (_salgKatalog[i].ID == id)
                {
                    return _salgKatalog[i];
                 
                }
                i++;
            }
            return null;
        }


        public static void OpretSalg(Salg salg)
        {
            _salgKatalog.Add(salg);

        }
    }
}