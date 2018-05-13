using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers.Products
{
    class DeleteCosController
    {
        public static int returnCategorie(string s)
        {
            int currentProduct = -1;
            switch (s)
            {
                case "b1":
                    currentProduct = 0;
                    break;
                case "b2":
                    currentProduct = 1;
                    break;
                case "b3":
                    currentProduct = 2;
                    break;
                case "b4":
                    currentProduct = 3;
                    break;
                case "b5":
                    currentProduct = 4;
                    break;
                case "b6":
                    currentProduct = 5;
                    break;
                case "b7":
                    currentProduct = 6;
                    break;
                case "b8":
                    currentProduct = 7;
                    break;

            }
            return currentProduct;
        }
    }
}

