namespace CarDealerShip
{
    public class Login
    {
        private bool _succeslogin;

        private bool LoginForsøg(int ID, string Password)
        {
            if (MedarbejderKatalog.Contains(ID))
            {

                if (MedarbejderKatalog.ID.Password == Password)
                {

                    return _succeslogin = true;
                }
               
            }

            else
            {
                return _succeslogin = false;
            }
           
        }
    }
}