using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    class Bil
    {
        public Bil(string farve, int stelNr, bool ny, double motorStr, string type, double price, string fabrikant, string model)
        {
            _farve = farve;
            _stelNr = stelNr;
            _ny = ny;
            _motorStr = motorStr;
            _type = type;
            _price = price;
            _fabrikant = fabrikant;
            _model = model;
        }

        public string _farve
        {
            get { return _farve; }
            set { _farve = value; }
        }
        public int _stelNr
        {
            get { return _stelNr; }
            set { _stelNr = value; }
        }
        public bool _ny
        {
            get { return _ny; }
            set { _ny = value; }
        }
        public double _motorStr
        {
            get { return _motorStr; }
            set { _motorStr = value; }
        }
        public string _type
        {
            get { return _type; }
            set { _type = value; }
        }
        public double _price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string _fabrikant
        {
            get { return _fabrikant; }
            set { _fabrikant = value; }

        }
        public string _model
        {
            get { return _model; }
            set { _model = value; }
        }

        
    }
}
