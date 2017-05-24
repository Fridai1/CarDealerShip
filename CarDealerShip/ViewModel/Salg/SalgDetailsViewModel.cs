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

        public long Name
        {
            get
            {
                return DomainObject.getTLF;
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