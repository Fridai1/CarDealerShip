using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace CarDealerShip
{
    public static class IdGenerator
    {
        private static Random _ID; // statisk Instance field _ID af typen Random, som er en .Net classe.
        private static List<int> _IDList; // laver en statisk liste af typen int til at opbevarer eksisterende ID nr, for at forhindre duplications.
          static IdGenerator()
        {
            _ID = new Random(); // instancere Random
            _IDList = new List<int>(); // opretter listen.
        }

        public static int GenerateIdChef()  // Statisk klasse for at oprette et ID for en CHEF.
        {
            int value = _ID.Next(2000, 2999); // laver et ID der er mellem 2000-2999 og gemmer værdien i value.
            for (int i = 0; i < 1000; i++)
          {
                if (_IDList.Contains(value)) // tjekker om den fundne værdi allerede eksistere blandt de andre ID'er 
                {                            // eksistere den laver den et nyt ID og starter loopet forfra indtil den har fundet et som ikke allerede eksistere
                    value = _ID.Next(2000, 2999);
                    i++;

                }
                else // når den finder et ID som ikke eksistere tilføjer den, ID'et i listen og retunere det nye ID.
                {
                 _IDList.Add(value);
                    i = 0;  // Dette burde Resette i til 0, hvergang den finder en værdi som ikke allerede eksistere, dette er for at forhindre den statiske klasse i at kører i>1000
                 return value;
                }
          }
            
            return value; // 
        }

        public static int GenerateIdSælger()  // fungere på samme måde some above.
        {
            int value = _ID.Next(1000, 1999);
            for (int i = 0; i < 1000; i++)
            {
                if (_IDList.Contains(value))
                {
                    value = _ID.Next(1000, 1999);
                    i++;

                }
                else
                {
                    _IDList.Add(value);
                    i = 0;
                    return value;
                }
            }

            return value;
        }
    }
}