using System.Linq.Expressions;
using Windows.Storage.Search;

namespace CarDealerShip
{
    public class Provision
    {
        private double _Provision;
        private double _solgt;

        public Provision()
        {
            double _provision = 0;
            double solgt = 100000;
        }

        public void provision()
        {
            int value = 5;

            if (Sælger.solgt >= 100000)
            {
                value = 1;
            }
            else if (Sælger.solgt >= 200000)
            {
                value = 2;
            }
            else if (Sælger.solgt >201000)
            {
                value = 3;
            }


            
            switch (value)
            {
                case 1:
                    _Provision = _solgt * 1.05;
                    break;

                case 2:
                    _Provision = _solgt * 1.07;
                    break;

                case 3:
                    _Provision = _solgt * 1.10;
                    break;
            }


        }
    }

    
}