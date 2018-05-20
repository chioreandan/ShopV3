using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers.Products
{
    internal class CategorieController
    {
       public static List<Produse> getProduse(string categorie)
        {
            List<Produse> produses = new List<Produse>();
            List<Produse> prod2 = new List<Produse>();
            produses = ProduseController.getByCategory();
            foreach(Produse p in produses)
            {
                if (p.CategoriiProduse.NumeCategorie == categorie)
                {
                    prod2.Add(p);
                }
            }
            return prod2;
        }
        public static List<Produse> getProduseBySeller(string categorie, int vanzatorID)
        {
            List<Produse> produses = new List<Produse>();
            List<Produse> produs = new List<Produse>();

            foreach (Produse p in produses)
            {
                if (p.CategoriiProduse.NumeCategorie == categorie && p.VanzatorId == vanzatorID)
                {
                    produs.Add(p);
                }
            }
            return produs;
        }

    }
}
