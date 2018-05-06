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

    }
}
