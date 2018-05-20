using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers.Buy
{
    class CumparareItemController
    {
        private static ShopEntities shop = new ShopEntities();
        public static List<CumparareItem> GetCumparareItems()
        {
            return shop.CumparareItems.ToList();
        }
        public static void AddCumparareItem(CumparareItem cumparareItem)
        {
            shop.CumparareItems.Add(cumparareItem);
            shop.SaveChanges();
        }
    }
}
