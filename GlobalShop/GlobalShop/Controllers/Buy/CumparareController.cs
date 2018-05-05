using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers.Buy
{
    class CumparareController
    {
        private static ShopEntities shop = new ShopEntities();

        public static void AddCumparare(Cumparare cumparare)
        {
            shop.Cumparares.Add(cumparare);
            shop.SaveChanges();
        }
    }
}
