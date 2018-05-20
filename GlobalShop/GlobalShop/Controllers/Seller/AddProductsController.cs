using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalShop.Controllers.Seller
{
    internal class AddProductController
    {
        private static ShopEntities shop = new ShopEntities();
        public static void AddProduct(string Nume, decimal Pret, int Stoc, string Caracteristici, string Imagine, int CategorieId, int BrandId, int VanzatorID)
        {
            Produse produs = new Produse(Nume, Pret, Stoc, Caracteristici, Imagine, CategorieId, BrandId, VanzatorID);
            AddProductController.CreateProduct(produs);
            MessageBox.Show("Produs adaugat cu succes", "ADAUGAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void CreateProduct(Produse produs)
        {
            shop.Produses.Add(produs);
            shop.SaveChanges();
        }
    }
}
