using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers.Products
{
    public class ProduseController
    {
        private static ShopEntities shop = new ShopEntities();


        public static IEnumerable<Produse> GetProduse() => shop.Produses.ToList();

        public static Produse GetProdus(int CategorieId) 
        {
            return null;
        }

        public static void CreateProdus(Produse produs)
        {
            shop.Produses.Add(produs);
            shop.SaveChanges();
        }
        public static List<Produse> getByCategory()
        {
            List<Produse> produse = new List<Produse>();
            produse=shop.Produses.Where(s => s.CategoriiProduse.CategorieId == 1).ToList();
            return produse;
        }
    }
}
