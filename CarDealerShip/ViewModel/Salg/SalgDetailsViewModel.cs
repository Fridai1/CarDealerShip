using CarDealerShip.ViewModel.Base;

namespace CarDealerShip
{
    public class SalgDetailsViewModel : DetailsViewModelBase<Salg>
    {
        public SalgDetailsViewModel(Salg obj) : base(obj)
        {
        }

        public int ID
        {
            get
            {
                return DomainObject.ID;
            }
        }

        public string Name
        {
            get
            {
                return DomainObject.GetName;
            }
        }

        public double Price
        {
            get
            {
                return DomainObject.Price;
            }
        }
    }

}