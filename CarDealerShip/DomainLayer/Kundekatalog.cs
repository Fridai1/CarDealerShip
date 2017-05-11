using System.Collections.Generic;

namespace CarDealerShip
{
    public class KundeKatalog
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

        private KundeKatalog()
        {
            
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

        public void Delete(Kunde aKunde) //slet kunde
        {
            _Kundelist.Remove(aKunde);
        }
    }
}