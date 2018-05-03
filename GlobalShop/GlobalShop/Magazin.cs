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
using GlobalShop.Controllers.Products;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace GlobalShop
{
    public partial class Magazin : MetroForm
    {
        User user;
        public static List<Produse> produses;
        Button button = new Button();
        //Button clickedButton = (Button)sender;

        int currentProduct;
        //button.Click += new EventHandler(button_Click);

        public Magazin(User user)
        {
            InitializeComponent();
            this.user = user;

        }
        public Magazin()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\ShopV3\\Poze produse\\acer.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\ShopV3\\Poze produse\\acer.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\ShopV3\\Poze produse\\acer.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\ShopV3\\Poze produse\\acer.jpg");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\ShopV3\\Poze produse\\acer.jpg");
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\ShopV3\\Poze produse\\acer.jpg");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\ShopV3\\Poze produse\\acer.jpg");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\ShopV3\\Poze produse\\acer.jpg");
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            

          





        }

        private void Magazin_Load(object sender, EventArgs e)
        {
            produses = ProduseController.GetProduse().ToList();
            foreach (Produse p in produses)
                comboBox2.Items.Add(p.NumeProdus);
            //autocomplete
            this.comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            //size of window
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            //produse
            List<PictureBox> pictures = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
            List<Label> smallLabels = new List<Label> { label3, label4, label5, label6, label7, label8, label9, label10 };
            List<Label> bigLabels = new List<Label> { label13, label14, label15, label16, label17, label18, label19, label20 };
            List<Button> buttons = new List<Button> { button11, button12, button12, button13, button14, button15, button16, button17, button18 };

            produses = RandomProducts.RandomProduse();
            for (int i = 0; i < 8; i++)
            {
                smallLabels[i].Text = null;
                string produ = produses[i].NumeProdus.ToString();
                string[] vs = produ.Split(' ');
                for (int j = 0; j < vs.Length; j++)
                {
                    smallLabels[i].Text += vs[j] + " ";
                    if (j % 3 == 0 && j != 0)
                    {
                        smallLabels[i].Text += "\n";
                    }

                }
                bigLabels[i].Text = produses[i].Pret.ToString() + " Lei";

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            produses = CategorieController.getProduse(button.Text.ToString());
            List<PictureBox> pictures = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
            List<Label> smallLabels = new List<Label> { label3, label4, label5, label6, label7, label8, label9, label10 };
            List<Label> bigLabels = new List<Label> { label13, label14, label15, label16, label17, label18, label19, label20 };
            List<Button> buttons = new List<Button> { button11, button12, button13, button14, button15, button16, button17, button18 };
            
            for (int i = 0; i < produses.Capacity; i++)
            {

                smallLabels[i].Text = null;
                string produ = produses[i].NumeProdus.ToString();
                string[] vs = produ.Split(' ');
                for (int j = 0; j < vs.Length; j++)
                {
                    smallLabels[i].Text += vs[j] + " ";
                    if (j % 3 == 0 && j != 0)
                    {
                        smallLabels[i].Text += "\n";
                    }

                }
                bigLabels[i].Text = produses[i].Pret.ToString() + " Lei";
                currentProduct = i;
               
            }
            for (int i = produses.Capacity; i < 8; i++)
            {
                pictures[i].Image = null;
                smallLabels[i].Text = null;
                bigLabels[i].Text = null;
                buttons[i].Hide();
            }


        }


        private void button11_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null)
                return;
            switch (clickedButton.Name)
            {
                case "button11":
                    currentProduct = 0;
                    break;
                case "button12":
                    currentProduct = 1;
                    break;
                case "button13":
                    currentProduct = 2;
                    break;
                case "button14":
                    currentProduct = 3;
                    break;
                case "button15":
                    currentProduct = 4;
                    break;
                case "button16":
                    currentProduct = 5;
                    break;
                case "button17":
                    currentProduct = 6;
                    break;
                case "button18":
                    currentProduct = 7;
                    break;

            }
            panel4.Visible = true;
            panel2.Visible = false;
            DateTime tomorrow = DateTime.Now.AddDays(1);
            label23.Text = "Livrare standard: Ajunge in data de " + tomorrow.ToString("dd-MM-yyyy");
            pictureBox9.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\ShopV3\\Poze produse\\acer.jpg");
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            label24.Text = produses[currentProduct].NumeProdus;
            pret.Text = produses[currentProduct].Pret.ToString() + " Lei";

            if (CheckStoc.Check(produses[currentProduct]) == true)
            {
                label12.Text = "In Stoc";
                label12.BackColor = Color.Green;
            }
            else if (CheckStoc.Check(produses[currentProduct]) == false)
            {
                label12.Text = "Stoc epuizat";
                label12.BackColor = Color.Red;

            }
            label21.Text = produses[currentProduct].Caracteristici;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel2.Visible = true;
        }
       
    }
}
