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
using GlobalShop.Controllers.Buy;
namespace GlobalShop
{
    public partial class UserProfile : MetroForm
    {
        User user;
        List<Cumparare> cumparare;
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
          
            textBox1.Text = user.NumePrenume;
            textBox2.Text = user.Telefon;
            textBox3.Text = user.Adresa;
            textBox5.Text = user.Email;
            textBox4.Text = user.Parola;
            List<Label> comandaId = new List<Label> { c1, c2, c3, c4, c5, c6 };
            List<Label> subtotal = new List<Label> { sub1, sub2, sub3, sub4, sub5, sub6 };
            cumparare = ControllerComenzi.getComenzi(user.UserId);
            for(int i = 0; i < cumparare.Count; i++)
            {
                comandaId[i].Text = "Comanda cu numarul: "+ cumparare[i].CumparareId.ToString();
                Console.WriteLine(ControllerComenzi.getSubtotal(cumparare[i].CumparareId));
                subtotal[i].Text = ControllerComenzi.getSubtotal(cumparare[i].CumparareId).ToString()+ ".00 Lei";
            }
            for(int i = cumparare.Count; i < 6; i++)
            {
                comandaId[i].Visible = false;
                subtotal[i].Visible = false;
            }
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
            try
            {
                UserController.UserUpdateDate(textBox1.Text, textBox3.Text, textBox2.Text, user.UserId);
                MessageBox.Show("Modificarile au fost salvate cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch 
            {
                MessageBox.Show("A aparut o eroare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                UserController.UserUpdateSecuritate(textBox5.Text, textBox4.Text, user.UserId);
                MessageBox.Show("Modificarile au fost salvate cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("A aparut o eroare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
