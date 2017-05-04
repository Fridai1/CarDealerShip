﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    class Medarbejder: Person
    {
        private int _id;
        private string _password;

        public int Id
        {
            get { return _id; }
            set
            {
            }
        }

        public string Password
        {
            set { _password = value; }
        }

        public Medarbejder (string Navn, string Password) : base(Navn)
        {
            _id = IdGenerator.GenerateIdChef();
            _password = Password; 
        }

        public bool ValidatePassword(string Password) //tjekker om Password parameter er lig med instans værdien
        {
            return _password.Equals(Password);
        }


    }
}
