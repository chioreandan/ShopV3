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

        public static void AddProduct(string Nume, decimal Pret, int Stoc, string Caracteristici, string Imagine, int CategorieId, int BrandId,int VanzatorID)
        {
            Produse produs = new Produse(Nume, Pret, Stoc, Caracteristici, Imagine, CategorieId, BrandId, VanzatorID);
            // try
            //{
            AddProductController.CreateProduct(produs);
            MessageBox.Show("Produs adaugat cu succes", "ADAUGAT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //catch (Exception )
            //{
            // MessageBox.Show("Nu s-a putut adauga un produs", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }
        }
        public static void CreateProduct(Produse produs)
        {
            shop.Produses.Add(produs);
            shop.SaveChanges();

        }

    }
}
