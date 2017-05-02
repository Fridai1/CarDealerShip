using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace CarDealerShip
{
    public static class IdGenerator
    {
        private static Random _ID;
        private static List<int> _IDList;
          static IdGenerator()
        {
            _ID = new Random();
            _IDList = new List<int>();
        }

        public static int GenerateIdChef()
        {
            int value = _ID.Next(2000, 2999);
            for (int i = 0; i < 1000; i++)
          {
                if (_IDList.Contains(value))
                {
                    value = _ID.Next(2000, 2999);
                    i++;

                }
                else
                {
                 _IDList.Add(value);
                 return value;
                }
          }
            
            return value;
        }

        public static int GenerateIdSælger()
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
                    return value;
                }
            }

            return value;
        }
    }
}