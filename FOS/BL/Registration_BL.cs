using FOS.DL;
using FOS.DTO;
using FOS.GUI;


namespace FOS.BL
{
    class Registration_BL
    {
         Registration_DL _lgDL;

        public Registration_BL()
        {
            _lgDL = new Registration_DL();
        }

        public Form VerifyUser(Registration_DTO lgDTO)
        {
            User_DTO ud = _lgDL.verifyuserfromDb(lgDTO);
            if (ud == null)
            {
                return new WrongUser_GUI();
            }
            if (ud.Role=="admin")
            {
                return new Admin_GUI(ud);
            }
            else if (ud.Role=="Customer")
            {
                return new Customer_GUI(ud);
            }
            else
            {
                return new WrongUser_GUI();
            }
            return new WrongUser_GUI();

        }

        public bool Signup(User_DTO ud)
        {
            return _lgDL.createaccountn_db(ud);
        }
    }
}
    

