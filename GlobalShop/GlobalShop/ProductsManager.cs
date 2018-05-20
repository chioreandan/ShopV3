using GlobalShop.Controllers.Seller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalShop.Controllers;
using System.Diagnostics;
using GlobalShop.Controllers.Products;

namespace GlobalShop
{
    public partial class ProductsManager : Form
    {
        Vanzatori vanzator;
        public ProductsManager()
        {
            InitializeComponent();
        }
        public ProductsManager(Vanzatori vanzator)
        {
            this.vanzator = vanzator;
        }

        private void ProductsManager_Load(object sender, EventArgs e)
        {

            myProductsPanel.Visible = false;
            addProductLabel.Visible = false;
            panel3.Visible = false;
            dateFirma.Visible = true;
            VizualizareComenzi.Visible = false;

            Vanzatori vanzator = VanzatorController.GetSellerById(getUserID_Vanzatordb());
            User user = UserController.GetUserById(getUserID_Vanzatordb());

            cui.Text = vanzator.CUI;
            nume_Companie.Text = vanzator.NumeCompanie;
            cont.Text = vanzator.Cont;
            emailCompanie.Text = user.Email;//emailUser;


            emailActiv.Text = user.Email;// getinformation.Email;
            parolaContVanzator.Text = user.Parola;// getinformation.Parola;
        }
        public int getUserID_Vanzatordb()
        {
            ShopEntities shop = new ShopEntities();
            Form1 form1 = new Form1();
            string emailUser = Form1.emailAdress;
            var getinformation = shop.Users.Where(a => a.Email == emailUser).FirstOrDefault();
            int userID_Vanzatordb = getinformation.UserId;



            return userID_Vanzatordb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProductLabel.Visible = true;
            myProductsPanel.Visible = false;
            dateFirma.Visible = false;
            panel3.Visible = false;
        }

        private void viewProducts_Click(object sender, EventArgs e)
        {
            myProductsPanel.Visible = true;
            addProductLabel.Visible = false;
            panel3.Visible = false;
            dateFirma.Visible = false;
        }

        private void datePersonaleBtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            addProductLabel.Visible = false;
            myProductsPanel.Visible = false;
            dateFirma.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UserController.UserUpdateSecuritate(emailActiv.Text, parolaContVanzator.Text, getUserID_Vanzatordb());
            VanzatorController.SellerUpdateDate(nume_Companie.Text, cont.Text, cui.Text, getUserID_Vanzatordb());
            MessageBox.Show("Date modificate cu succes!");

        }

        private void back_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            addProductLabel.Visible = false;
            myProductsPanel.Visible = true;
            dateFirma.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myProductsPanel.Visible = false;
            addProductLabel.Visible = false;
            panel3.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            myProductsPanel.Visible = false;
            addProductLabel.Visible = false;
            panel3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myProductsPanel.Visible = false;
            addProductLabel.Visible = false;
            panel3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myProductsPanel.Visible = false;
            addProductLabel.Visible = false;
            panel3.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myProductsPanel.Visible = false;
            addProductLabel.Visible = false;
            panel3.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            myProductsPanel.Visible = false;
            addProductLabel.Visible = false;
            panel3.Visible = true;
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            string nume = ProductNameTextBox.Text;
            decimal pret = Decimal.Parse(pretTExtBox.Text);
            int stocProduse = int.Parse(stoc.Text);
            string caracteristici = textBox1.Text;
            int optiune = checkedListBox1.SelectedIndex + 1;
            int optiune1 = checkedListBox2.SelectedIndex + 1;
            //byte[] imagine = imageToByteArray(pictureBox1.Image);
            string imagine = Path.GetDirectoryName(pictureBox1.ImageLocation);

            ShopEntities shop = new ShopEntities();
            Form1 form1 = new Form1();
            string emailUser = Form1.emailAdress;
            var getinformation = shop.Users.Where(a => a.Email == emailUser).FirstOrDefault();
            int vanzator_id = getinformation.UserId;


            try
            {

                AddProductController.AddProduct(nume, pret, stocProduse, caracteristici, imagine, optiune, optiune1, vanzator_id);
                deleteLabels();

            }
            catch
            {
                MessageBox.Show("A aparut o eroareeeeee", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void deleteLabels()
        {
            ProductNameTextBox.Text = "";
            pretTExtBox.Text = "";
            stoc.Text = "";
            textBox1.Text = "";
            pictureBox1.Image = null;
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void Laptopbutton_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            addProductLabel.Visible = false;
            myProductsPanel.Visible = true;
            dateFirma.Visible = false;
            VizualizareComenzi.Visible = false;
            List<Produse> produses = new List<Produse>();


            Vanzatori vanzator = VanzatorController.GetSellerById(getUserID_Vanzatordb());
            Button button = sender as Button;
            produses = CategorieController.getProduseBySeller(button.Text.ToString(), vanzator.VanzatorId);

            List<PictureBox> poze = new List<PictureBox> { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            List<Label> labels = new List<Label> { label5, label6, label7, label8, label9, label10 };
            List<Button> buttons = new List<Button> { Laptopbutton, TableteButton, Pc_Periferice_button, haine_button,
                                                      telefoaneBUtton, button6, carti_button, Auto_moto_button };

            for (int i = 0; i < produses.Count; i++)
            {
                labels[i].Text = null;
                string numeProdus = produses[i].NumeProdus;
                string[] vs = numeProdus.Split(' ');

                for (int j = 0; j < vs.Length; j++)
                {
                    labels[i].Text += vs[j] + " ";
                    if (j % 3 == 0 && j != 0)
                    {
                        labels[i].Text += "\n";
                    }
                }
                if (i == 0) { }

            }
            /*
            for (int i = produses.Count; i < 8; i++)
            {
                poze[i].Image = null;
                labels[i].Text = null;
                buttons[i].Hide();
            }
            */
        }
    }
}
