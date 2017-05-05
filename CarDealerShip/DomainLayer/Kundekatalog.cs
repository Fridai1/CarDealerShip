using System.Collections.Generic;

namespace CarDealerShip
{
    class KundeKatalog
    {
        private List<Kunde> _kundes;

        public KundeKatalog()
        {
            _kundes = new List<Kunde>();
        }

        public void AddKunde(Kunde aKunde) //test
        {
            _kundes.Add(aKunde);
        }

        public Kunde GetKunde(long telefon)
        {
            Kunde x;
            x = null;
            foreach (var y in _kundes)
            {
                if (y.telefon == telefon) x = y;


            }
            return x;
        }

        public void Delete(Kunde aKunde)
        {
            _kundes.Remove(aKunde);
        }
    }
}