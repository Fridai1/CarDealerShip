namespace CarDealerShip
{
    public class Salg : DomainClassBase
    {
        private double _price;
        private int _id;
        private string _name;
         


        public string GetName
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price //der er ingen grund til at kunne rette i prisen for en bil når salget er foretaget, derfor er der kun en get og ikk en set
        {
            get { return _price; }
            set { _price = value; }
        }

        public int ID //samme som ovenover, her skal man kun kunne hente oplysningerne ikke rette dem
        {
            get { return _id; }
            set { _price = value; }
        }

        public override void SetDefaultValues()
        {
            _name = "name";
            _id = 007;
            _price = 0;
        }
    }
}