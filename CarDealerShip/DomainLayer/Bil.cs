using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    public class Bil : DomainClassBase
    {
        private string _farve;
        private long _stelNr;
        private bool _ny;
        private double _motorStr;
        private string _type;
        private double _price;
        private string _fabrikant;
        private string _model;
        private string _photoID;

        //public Bil(string farve, long stelNr, bool ny, double motorStr, string type, double price, string fabrikant, string model)
        //{
        //    _farve = farve;
        //    _stelNr = stelNr;
        //    _ny = ny;
        //    _motorStr = motorStr;
        //    _type = type;
        //    _price = price;
        //    _fabrikant = fabrikant;
        //    _model = model;
        //}

        public string Farve
        {
            get { return _farve; }
            set { _farve = value; }
        }
        
        public long StelNr
        {
            get { return _stelNr; }
            set { _stelNr = value; }
        }

        public bool Ny
        {
            get { return _ny; }
            set { _ny = value; }
        }

        public double MotorStr
        {
            get { return _motorStr; }
            set { _motorStr = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Fabrikant
        {
            get { return _fabrikant; }
            set { _fabrikant = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string PhotoID
        {
            get { return _photoID; }
            set { _photoID = value; }
        }

        public string ImageSource
        {
            get { return AppConfig.ImageFilePrefix + "Bil\\" + PhotoID + AppConfig.ImageFilePostfix; }
        }

        public override void SetDefaultValues()
        {
            _farve = "sort";
            _stelNr = 99999999;
            _ny = true;
            _motorStr = 2.0;
            _type = "station car";
            _price = 99999;
            _fabrikant = "Skoda";
            _model = "superb";
            _photoID = "bmw";
        }
    }
}
