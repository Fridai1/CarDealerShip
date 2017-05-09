﻿using System.Linq.Expressions;
using Windows.Storage.Search;
using CarDealerShip.DomainLayer;

namespace CarDealerShip
{
    public class Provision
    {
        private double _Provision;

        private int _value;
        private int _id;
        private double _solgt;
        public Provision(int id)
        {
            double _provision = 0;

            _value = 0;
            _id = id;
            _solgt = SalgKatalog.GetSalg(_id).Price;






        }

        public void provision()
        {


            if (_solgt >= 1 || _solgt <= 99999)
            {
                _Provision = _solgt * 1.05;
                //_value = 1;
            }
            else if (_solgt >= 100000 || _solgt < 200000)
            {
                //_value = 2;
                _Provision = _solgt * 1.05;
            }
            else if (_solgt > 200000)
            {
                //_value = 3;
                _Provision = _solgt * 1.10;
            }
        }

        public double Getprovision => _Provision;

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