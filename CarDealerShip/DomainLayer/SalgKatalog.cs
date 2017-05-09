using System.Collections.Generic;

namespace CarDealerShip
{
    public class SalgKatalog
    {
        private List<Salg> _salgKatalog;

        public SalgKatalog()
        {
            _salgKatalog = new List<Salg>();
        }

        public Salg GetSalg(int id)
        {
            foreach (Salg salg in _salgKatalog)
            {
                if (salg.ID == id)
                {
                    return salg;
                }
            }

            return null;
        }

        public void OpretSalg(Salg salg)
        {
            _salgKatalog.Add(salg);

        }
    }
}