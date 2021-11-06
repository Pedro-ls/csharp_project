using projectRoupas.lib;
using projectRoupas.models;
using projectRoupas.Util;
using System;
using System.Windows.Forms;

namespace projectRoupas.views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblPassword.PasswordChar = '*';
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //pega campos do login

            String username = lblEmail.Text;
            String password = lblPassword.Text;

            UserModel user = new UserModel(); // instancia o model de conexão

            User userObject  = user.login(username, password); //faz login e retorna status

            try
            {
                if (userObject != null)
                {
                    MessageBox.Show("Logado Bem vindo!");

                    StateGlobal.user = userObject;

                    ScreenMain screen = new ScreenMain();

                    screen.Show();

                }
                else
                {
                    MessageBox.Show("Credencial errada!!!, tente novamente!!!"); // mesagem de erro
                }  
                
            }
            catch (Exception ex) {
                MessageBox.Show("erro na conexão" + ex.Message.ToString());
            }

                    
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
