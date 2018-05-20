using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers.Buy
{
    class ControllerComenzi
    {
        public static List<Cumparare> getComenzi(int UserId)
        {
            List<Cumparare> cumparares = new List<Cumparare>();
            List<Cumparare> cumparareByUser = new List<Cumparare>();
            List<CumparareItem> cumparareItems = new List<CumparareItem>();
            cumparares = CumparareController.getCumparare;
            cumparareItems = CumparareItemController.GetCumparareItems();
            foreach(Cumparare c in cumparares)
            {
                if (c.UserId == UserId)
                {
                    cumparareByUser.Add(c);
                }
            }
            return cumparareByUser;
        }
        public static decimal getSubtotal(int CumparareId)
        {
            decimal sum=0;
            List<CumparareItem> cumparareItems = new List<CumparareItem>();
            cumparareItems = CumparareItemController.GetCumparareItems();
            foreach(CumparareItem c in cumparareItems)
            {
                if (CumparareId == c.CumparareId)
                {
                    sum = sum + c.Produse.Pret*Convert.ToDecimal(c.NumarIteme);
                }
            }
            return sum;
        }
    }
}
