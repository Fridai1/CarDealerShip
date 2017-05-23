using System.Collections.Generic;
using System.Linq;

namespace CarDealerShip.DomainLayer
{
    public class SalgKatalog : CatalogBase<Salg>
    {

        private static SalgKatalog _instance = null;
        private Dictionary<int, Salg> _bilkatalog;

        public static SalgKatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new SalgKatalog();
                return _instance;
            }
        }

        public SalgKatalog() : base(new CollectionBase<Salg>())
        {
            _bilkatalog = new Dictionary<int, Salg>();

        }




        //public  List<Salg> Salgs { get { return _salgKatalog.ToList(); } }

        //public  double GetTotalSalg(int id)
        //{
        //    int i = 0;
        //    double value = 0;

        //    while (i < _salgKatalog.Count)
        //    {
        //        if (_salgKatalog[i].ID == id)
        //        {
        //            double plus = _salgKatalog[i].Price;
        //            value = plus + value;
        //        }
        //        i++;
        //    }
        //    return value;
        //}



        //public int GetIdSalg(int id)
        //{
        //    int i = 0;

        //    while (i < _salgKatalog.Count)
        //    {
        //        if (_salgKatalog[i].ID == id)
        //        {
        //            return _salgKatalog[i].ID;
        //        }
        //        i++;
        //    }
        //    return 0;
        //}


        //public  void OpretSalg(Salg salg)
        //{
        //    _salgKatalog.Add(salg);

        //}
    }
}