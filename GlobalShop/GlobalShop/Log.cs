using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalShop.Controllers;
using MetroFramework.Forms;

namespace GlobalShop
{
    public partial class Log : MetroForm
    {
         private string email;
        public Log(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void continua_Click(object sender, EventArgs e)
        {
            if (LoginController.CheckPass(email, parola.Text)==true)
            {
                User user = new User();
                user = UserController.GetUser(email);
                if (LoginController.CheckVanzator(user.UserId) == false && LoginController.CheckAdmin(user.UserId)==false)
                {
                    Magazin magazin = new Magazin(user);
                    magazin.Show();
                }
                else if(LoginController.CheckAdmin(user.UserId)==true && LoginController.CheckVanzator(user.UserId) == false)
                {
                    AdministratorWindow administratorWindow = new AdministratorWindow();
                    administratorWindow.Show();

                }
                else if (LoginController.CheckVanzator(user.UserId) == true && LoginController.CheckAdmin(user.UserId)==false)
                {
                    //AddProducts addProducts = new AddProducts();
                    //addProducts.Show();
                    ProductsManager productsManager = new ProductsManager();
                    productsManager.Show();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Parola nu este corecta", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Log_Load(object sender, EventArgs e)
        {

        }
    }
}
