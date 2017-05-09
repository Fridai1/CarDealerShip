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


        public void OpretSalg(Salg salg)
        {
            _salgKatalog.Add(salg);

        }
    }
}