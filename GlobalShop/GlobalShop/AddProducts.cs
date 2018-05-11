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


namespace GlobalShop
{
    public partial class AddProducts : Form
    {

        Vanzatori vanzator;
        public AddProducts()
        {
            InitializeComponent();
        }
        public AddProducts(Vanzatori vanzator)
        {
            this.vanzator = vanzator;

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            string nume = ProductNameTextBox.Text;
            decimal pret = Decimal.Parse(pretTExtBox.Text);
            int stocProduse = int.Parse(stoc.Text);
            string caracteristici = textBox1.Text;
            int optiune = checkedListBox1.SelectedIndex + 1;
            int optiune1 = checkedListBox2.SelectedIndex + 1;
            byte[] imagine = imageToByteArray(pictureBox1.Image);
            try
            {

                AddProductController.AddProduct(nume, pret, stocProduse, caracteristici, imagine, optiune, optiune1);

            }
            catch
            {
                MessageBox.Show("A aparut o eroareeeeee", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //convert Image-to-byte[]
        private byte[] imageToByteArray(Image imagine)
        {
            MemoryStream ms = new MemoryStream();
            imagine.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void imagine_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg|*.jpg";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            
            
        }
    }
}
