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
using System.IO;
using GlobalShop.Controllers.Buy;

namespace GlobalShop
{
    public partial class Magazin : MetroForm
    {
        Produse produs;
        User user;

        public List<Produse> cos;
        public static List<Produse> produses;

        Button button = new Button();

        int currentProduct;
        int pressed = 0;

        //Button clickedButton = (Button)sender;


        //button.Click += new EventHandler(button_Click);

        public Magazin(User user)
        {
            InitializeComponent();
            this.user = user;
          
        }
        public Magazin()
        {
            InitializeComponent();
          
        }

        private void Magazin_Load(object sender, EventArgs e)
        {
            List<PictureBox> pictures = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
            List<Label> smallLabels = new List<Label> { label3, label4, label5, label6, label7, label8, label9, label10 };
            List<Label> bigLabels = new List<Label> { label13, label14, label15, label16, label17, label18, label19, label20 };
            List<Button> buttons = new List<Button> { button11, button12, button12, button13, button14, button15, button16, button17, button18 };

            cos = new List<Produse>();
            //panel5.Visible = false;
            produses = ProduseController.GetProduse().ToList();
            foreach (Produse p in produses)
                comboBox2.Items.Add(p.NumeProdus);
            this.comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            
            produses = RandomProducts.RandomProduse();
            for (int i = 0; i < 8; i++)
            {
                smallLabels[i].Text = null;
                pictures[i].Image = Image.FromFile(@produses[i].Imagine);
                pictures[i].SizeMode = PictureBoxSizeMode.StretchImage;
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
                bigLabels[i].Text = produses[i].Pret.ToString() + ".00 Lei";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            Button button = sender as Button;
            produses = CategorieController.getProduse(button.Text.ToString());
            List<PictureBox> pictures = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
            List<Label> smallLabels = new List<Label> { label3, label4, label5, label6, label7, label8, label9, label10 };
            List<Label> bigLabels = new List<Label> { label13, label14, label15, label16, label17, label18, label19, label20 };
            List<Button> buttons = new List<Button> { button11, button12, button13, button14, button15, button16, button17, button18 };
            Console.WriteLine();
            for (int i = 0; i < produses.Count; i++)
            {
                smallLabels[i].Text = null;
                string produ = produses[i].NumeProdus;
                pictures[i].Image = Image.FromFile(@produses[i].Imagine);
                pictures[i].SizeMode = PictureBoxSizeMode.StretchImage;
                string[] vs = produ.Split(' ');
                for (int j = 0; j < vs.Length; j++)
                {
                    smallLabels[i].Text += vs[j] + " ";
                    if (j % 3 == 0 && j != 0)
                    {
                        smallLabels[i].Text += "\n";
                    }
                }
                bigLabels[i].Text = produses[i].Pret.ToString() + ".00 Lei";
                if (i == 0)
                {
                   
                }

            }
            for (int i = produses.Count; i < 8; i++)
            {
                pictures[i].Image = null;
                smallLabels[i].Text = null;
                bigLabels[i].Text = null;
                if (i > produses.Count + 1)
                {
                    buttons[i].Hide();
                }
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null)
                return;
            currentProduct = ButtonController.returnCategorie(clickedButton.Name);
            produs = new Produse();

            produs = produses[currentProduct];
            panel5.Visible = false;
            panel4.Visible = true;
            panel2.Visible = false;
            DateTime tomorrow = DateTime.Now.AddDays(1);
            label23.Text = "Livrare standard: Ajunge in data de " + tomorrow.ToString("dd-MM-yyyy");
          
            
            pictureBox9.Image = Image.FromFile(@produses[currentProduct].Imagine);
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
            pressed = 0;

            panel4.Visible = false;
            panel5.Visible = false;
            panel2.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
            List<Label> nume = new List<Label> { nume1, nume2, nume3, nume4, nume5, nume6, nume7, nume8 };
            List<Label> preturi = new List<Label> { pret1, pret2, pret3, pret4, pret5, pret6, pret7, pret8 };
            List<Label> stocuri = new List<Label> { stoc1, stoc2, stoc3, stoc4, stoc5, stoc6, stoc7, stoc8 };
            List<Label> buc = new List<Label> { buc1, buc2, buc3, buc4, buc5, buc6, buc7, buc8 };
            List<ComboBox> boxes = new List<ComboBox> { combo1, combo2, combo3, combo4, combo5, combo6, combo7, combo8 };
            List<Button> buttons = new List<Button> { b1, b2, b3, b4, b5, b6, b7, b8 };
            pressed = 0;

            for (int i = 0; i < cos.Count; i++)
            {
                nume[i].Show();
                preturi[i].Show();
                stocuri[i].Show();
                buc[i].Show();
                boxes[i].Show();
                buttons[i].Show();
                nume[i].Text = cos[i].NumeProdus;
                preturi[i].Text = cos[i].Pret.ToString() + " Lei";
                if (CheckStoc.Check(cos[i]) == true)
                {
                    stocuri[i].Text = "In Stoc";
                    stocuri[i].BackColor = Color.Green;
                }
                else if (CheckStoc.Check(produses[currentProduct]) == false)
                {
                    stocuri[i].Text = "Stoc epuizat";
                    stocuri[i].BackColor = Color.Red;
                }
            }
            for (int i = cos.Count; i < 8; i++)
            {
                nume[i].Hide();
                preturi[i].Hide();
                stocuri[i].Hide();
                buc[i].Hide();
                boxes[i].Hide();
                buttons[i].Hide();
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            pressed = 0;
            panel5.Visible = false;
            panel2.Visible = true;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (pressed == 0)
                cos.Add(produs);
            pressed++;
        }
        private void button28_Click(object sender, EventArgs e)
        {
            List<ComboBox> boxes = new List<ComboBox> { combo1, combo2, combo3, combo4, combo5, combo6, combo7, combo8 };
            Cumparare cumparare = new Cumparare();
            cumparare.UserId = user.UserId;
            CumparareController.AddCumparare(cumparare);
            for (int i = 0; i < cos.Count(); i++)
            {
                CumparareItem cumparareItem = new CumparareItem(cumparare.CumparareId, cos[i].ProdusId, Convert.ToInt32(boxes[i].Text));
                CumparareItemController.AddCumparareItem(cumparareItem);
            }
            MessageBox.Show("Comanda a fost trimisa cu succes");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile(user);
            profile.Show();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Button clickedButton2 = sender as Button;
            if (clickedButton2 == null)
                return;
            int item = DeleteCosController.returnCategorie(clickedButton2.Name);
            cos.RemoveAt(item);
            button21_Click(sender, e);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string numeProdus = comboBox2.Text;
            Console.WriteLine(numeProdus);
            Button clickedButton = sender as Button;
            if (clickedButton == null)
                return;
           
            produs = new Produse();

            produs = ProduseController.GetProduseByName(numeProdus);
            panel5.Visible = false;
            panel4.Visible = true;
            panel2.Visible = false;
            DateTime tomorrow = DateTime.Now.AddDays(1);
            label23.Text = "Livrare standard: Ajunge in data de " + tomorrow.ToString("dd-MM-yyyy");


            pictureBox9.Image = Image.FromFile(@produs.Imagine);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            label24.Text = produs.NumeProdus;
            pret.Text = produs.Pret.ToString() + " Lei";

            if (CheckStoc.Check(produs) == true)
            {
                label12.Text = "In Stoc";
                label12.BackColor = Color.Green;
            }
            else if (CheckStoc.Check(produs) == false)
            {
                label12.Text = "Stoc epuizat";
                label12.BackColor = Color.Red;

            }
            label21.Text = produs.Caracteristici;
        }
    }
}
