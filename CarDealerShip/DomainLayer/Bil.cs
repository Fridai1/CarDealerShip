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
            Farve = farve;
            StelNr = stelNr;
            Ny = ny;
            MotorStr = motorStr;
            Type = type;
            Price = price;
            Fabrikant = fabrikant;
            Model = model;
        }

        public string Farve;
        public int StelNr;
        public bool Ny;
        public double MotorStr;
        public string Type;
        public double Price;
        public string Fabrikant;
        public string Model;
    }
}
