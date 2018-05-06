using MetroFramework.Forms;
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

namespace GlobalShop
{
    public partial class UserProfile : MetroForm
    {
        User user;
        public UserProfile()
        {
            InitializeComponent();
        }
        public UserProfile(User user)
        {
            this.user = user;
            InitializeComponent();

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(UserController.GetUserById(user.UserId).NumePrenume);
            textBox1.Text = user.NumePrenume;
            textBox2.Text = user.Telefon;
            textBox3.Text = user.Adresa;
            textBox5.Text = user.Email;
            textBox4.Text = user.Parola;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserController.UserUpdateDate(textBox1.Text, textBox3.Text, textBox2.Text, user.UserId);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserController.UserUpdateSecuritate(textBox5.Text, textBox4.Text, user.UserId);
        }
    }
}
