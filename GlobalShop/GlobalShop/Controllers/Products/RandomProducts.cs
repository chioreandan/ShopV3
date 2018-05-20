using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers.Products
{
    internal class RandomProducts
    {
        internal static List<Produse> RandomProduse()
        {
            Random random = new Random();
            List<Produse> produse = new List<Produse>(8);
            List<Produse> lista = new List<Produse>();
            List<int> randomNumbers = new List<int>();
            int rand;
            lista = ProduseController.GetProduse().ToList();
            for (int i = 0; i < 8; i++)
            {
                do
                {
                    rand = random.Next(0, lista.Count());
                } while (randomNumbers.Contains(rand));
                randomNumbers.Add(rand);
                produse.Add(lista[randomNumbers[i]]);
            }
            return produse;
        }
    }
}
