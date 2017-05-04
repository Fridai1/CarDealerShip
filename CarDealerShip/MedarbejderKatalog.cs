using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;

namespace CarDealerShip
{
    class MedarbejderKatalog
    {
        private List<Medarbejder> _list;

        public MedarbejderKatalog()
        {
            _list = new List<Medarbejder>();
        }

        public void Add(Medarbejder x) //tilføj ny medarbejder
        {
            _list.Add(x);
        }

        public Medarbejder Get(int Id) //find medarbejder med bestemt id
        {
            Medarbejder y;
            y = null;
            foreach (var x in _list)
            {
                if (x.Id == Id) y = x; 
            }
            return y; 
        }

        public Medarbejder[] ShowList() //retunere array af medarbejder
        {
            Medarbejder[] resultat = new Medarbejder[_list.Capacity];
            _list.CopyTo(resultat);
            return resultat;
        }

        public void Delete(Medarbejder x) //fjerne medarbejder 
        {
            _list.Remove(x);
        }
    }
}
