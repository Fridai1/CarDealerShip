using System.Collections.Generic;

namespace CarDealerShip
{
    public static class KundeKatalog
    {
        private static List<Kunde> _kundes;

        static KundeKatalog()
        {
            _kundes = new List<Kunde>();
        }

        public static void AddKunde(Kunde aKunde) //tilføj kunde
        {
            _kundes.Add(aKunde);
        }

        public static Kunde GetKunde(long telefon) //find kunde med bestemt telefonnummer
        {
            Kunde x;
            x = null;
            foreach (Kunde y in _kundes)
            {
                if (y.TelefonNummer == telefon) x = y;


            }
            return x;
        }

        public static void Delete(Kunde aKunde) //slet kunde
        {
            _kundes.Remove(aKunde);
        }
    }
}