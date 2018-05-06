using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers.Administrator
{
    class AdminsController
    {
        private static ShopEntities shop = new ShopEntities();
        public static IEnumerable<Admin> GetAdmins() => shop.Admins.ToList();

    }
}
