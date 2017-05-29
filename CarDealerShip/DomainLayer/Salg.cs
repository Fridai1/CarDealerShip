namespace CarDealerShip
{
    public class Salg : DomainClassBase
    {
        private double _price;
        private int _id;
        private long _telefonNummer;
        private long _stelNummer;
         


        public long getTLF //grunden til at der både er en get og set, er fordi at dette er en klasse for sig selv, og "bare" gemmer de informationer som den får fra de andre klasser.
        {
            get { return _telefonNummer; }
            set { _telefonNummer = value; }
        }

        public double Price //samme som i name
        {
            get { return _price; }
            set { _price = value; }
        }

        public int ID //samme som i både name og price
        {
            get { return _id; }
            set { _price = value; }
        }

        public long getStelnummer
        {
            get { return _stelNummer; }
            set { _stelNummer = value; }
        }

        public override void SetDefaultValues() //dette er de værdier som en instance af klassen har angivet når den bliver angivet
        {
            _telefonNummer = 12345678;
            _id = 007;
            _price = 0;
            _stelNummer = 1234;
        }
    }
}