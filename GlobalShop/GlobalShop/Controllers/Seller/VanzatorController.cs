using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers.Seller
{
    class VanzatorController
    {
        private static ShopEntities shop = new ShopEntities();
        public static IEnumerable<Vanzatori> GetUsers() => shop.Vanzatoris.ToList();
        public static Vanzatori GetSellerById(int id) => shop.Vanzatoris.FirstOrDefault(v => v.UserId == id);


        public static void SellerUpdateDate(string numeCompanie, string cont, string cui, int vanzatorId)
        {
            Vanzatori sellerUpdate = VanzatorController.GetSellerById(vanzatorId);
            sellerUpdate.NumeCompanie = numeCompanie;
            sellerUpdate.Cont = cont;
            sellerUpdate.CUI = cui;
            shop.SaveChanges();

        }
    }
}
