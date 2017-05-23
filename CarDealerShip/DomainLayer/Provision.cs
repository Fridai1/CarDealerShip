using System.Linq.Expressions;
using Windows.Storage.Search;
using CarDealerShip.DomainLayer;

namespace CarDealerShip
{
    public class Provision
    {
        private double _Provision;

       
        private int _id;
        private double _solgt;
        public Provision(int id)
        {
            _Provision = 0;

            
            _id = id;
            //_solgt = SalgKatalog.Instance.GetTotalSalg(_id);






        }

        public void provision()
        {

            if (_solgt >= 1 || _solgt <= 99999)
            {
                _Provision = _solgt * 1.05 - _solgt;
                //_value = 1;
            }
            else if (_solgt >= 100000 || _solgt < 200000)
            {
                //_value = 2;
                _Provision = _solgt * 1.07 - _solgt;
            }
            else if (_solgt > 200000)
            {
                //_value = 3;
                _Provision = _solgt * 1.10 - _solgt;
            }
        }

        public double GetProv
        {
            get
            {
                if (_solgt >= 1 || _solgt <= 99999)
                {
                    _Provision = _solgt * 1.05 - _solgt;
                    
                }
                else if (_solgt >= 100000 || _solgt < 200000)
                {
                    
                    _Provision = _solgt * 1.07 - _solgt;
                }
                else if (_solgt > 200000)
                {
                    
                    _Provision = _solgt * 1.10 - _solgt;
                }
                return _Provision;
            }
        }
        //public double Getprovision => _Provision;

        //public int getID
        //{
        //    get { return SalgKatalog.Instance.GetIdSalg(_id); }
        //}

        public double GetTotalSolgt
        {
            get { return _solgt; }
        }

        //public double GetProvision
        //{
        //    get {
        //        switch (_value)
        //        {
        //            case 1:
        //                _Provision = _solgt * 1.05;
        //                break;

        //            case 2:
        //                 _Provision = _solgt * 1.05;
        //                break;

        //            case 3:
        //                _Provision = _solgt * 1.10;
        //                break;

        //        }
        //        return _Provision;
        //    }
        //}



    }

}