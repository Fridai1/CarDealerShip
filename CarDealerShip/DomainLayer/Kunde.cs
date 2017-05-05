namespace CarDealerShip
{
    class Kunde : Person
    {
        

        public Kunde(string name, string adresse, string email, int telefon) : base(adresse, email, name, telefon)
        {
            
        }

        public string name
        {
            get { return name; }
            set { name = value; }
        }

        public string adresse
        {
            get { return adresse; }
        }

        public string email
        {
            get { return email; }
        }

        public long telefon
        {
            get { return telefon; }
        }
        
        


    }
}