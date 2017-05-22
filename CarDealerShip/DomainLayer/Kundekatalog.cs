using System;
using System.Collections.Generic;

namespace CarDealerShip
{
    public class KundeKatalog : CatalogBase<Kunde>
    {
        private static KundeKatalog _instance = null;

        private List<Kunde> _Kundelist;
        public static KundeKatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new KundeKatalog();
                return _instance; 
            }
        }

        public KundeKatalog() : base (new CollectionBase<Kunde>())
        {
            _Kundelist = new List<Kunde>();
        }

        public void OpretKunde(Kunde akunde)
        {
            _Kundelist.Add(akunde);
        }

        public Kunde GetKunde(long telefon) //find kunde med bestemt telefonnummer
        {
            Kunde x;
            x = null;
            foreach (Kunde y in _Kundelist )
            {
                if (y.TelefonNummer == telefon) x = y;
            }
            return x;
        }

        public List<Kunde> GetKundeList { get { return _Kundelist; } }

        public void Delete(Kunde aKunde) //slet kunde
        {
            _Kundelist.Remove(aKunde);
        }
    } 
}