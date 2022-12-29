using FOS.BL;
using FOS.DL;
using FOS.DTO;

namespace FOS
{
    public partial class LoginScreen : Form
    {
        private Registration_DTO _lgDTO;
        private Registration_BL _lgBL;
        private User_DTO ud;
        public LoginScreen()
        {
            InitializeComponent();
            _lgDTO = new Registration_DTO();
            _lgBL = new Registration_BL();
            ud= new User_DTO();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            _lgDTO.Username=txt_username.Text;
            _lgDTO.Password = txt_password.Text;
            _lgBL.VerifyUser(_lgDTO).ShowDialog();
            txt_password.Clear();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txt_signupusername.Text == "" || txt_signuppassword.Text == "")) { 
                ud.UserID = txt_signupusername.Text;
                ud.Password = txt_signuppassword.Text;

                if (_lgBL.Signup(ud))
                {
                    MessageBox.Show("Account Created success!", "Notify!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_signupusername.Clear();
                        txt_signuppassword.Clear();
                        txt_signupusername.Focus();
                }
                    }
                else
                {
                    MessageBox.Show("Please input All fields!!!", "Warning!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Account with this userID Already exsits!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}