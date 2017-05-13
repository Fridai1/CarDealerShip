namespace CarDealerShip
{
    public class Salg
    {
        private double _price;
        private int _id;
        private string _name;
        

        public Salg(int ID, double Price, string name)
        {
            _id = ID;
            _price = Price;
            _name = name;
        }

        public string GetName
        {
            get { return _name; }
        }

        public double Price //der er ingen grund til at kunne rette i prisen for en bil når salget er foretaget, derfor er der kun en get og ikk en set
        {
            get { return _price; }
        }

        public int ID //samme som ovenover, her skal man kun kunne hente oplysningerne ikke rette dem
        {
            get { return _id; }
        }
    }
}