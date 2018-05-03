using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers.Products
{
    internal class CautareProduse
    {
        internal static List<string> searchP(string s)
        {
            List<Produse> produse = new List<Produse>();
            List<string> searched = new List<string>();
            produse = ProduseController.GetProduse().ToList();
            foreach(Produse p in produse)
            {
                
                int ok = 0;
                for(int i = 0; i < s.Length; i++)
                {
                    if (p.NumeProdus[i] != s[i])
                    {
                        ok = 1;
                    }
                }
                if (ok == 0)
                {
                    searched.Add(p.NumeProdus);
                }
            }

            return searched;
        }
        /*internal static string[] SuggestStrings(string s)
        {
            string[] suggest;
            List<Produse> produse = new List<Produse>();
            produse = ProduseController.GetProduse().ToList();
            foreach(Produse p in produse)
            {
                int ok = 0;
                for(int i = 0; i <= s.Length; i++)
                {
                    if (p.NumeProdus[i] != s[i])
                    {
                        ok = 1;
                    }
                }
                if (ok == 0)
                {
                    
                }
            }
        }*/
    }
}
