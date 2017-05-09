namespace CarDealerShip
{
    public class Salg
    {
        private double _price;
        private int _id;

        public Salg(int ID, double Price)
        {
            _id = ID;
            _price = Price;
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