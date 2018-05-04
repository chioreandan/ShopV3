using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers.Products
{
    class ButtonController
    {
        public static int returnCategorie(string s)
        {
            int currentProduct=-1;
            switch (s)
            {
                case "button11":
                    currentProduct = 0;
                    break;
                case "button12":
                    currentProduct = 1;
                    break;
                case "button13":
                    currentProduct = 2;
                    break;
                case "button14":
                    currentProduct = 3;
                    break;
                case "button15":
                    currentProduct = 4;
                    break;
                case "button16":
                    currentProduct = 5;
                    break;
                case "button17":
                    currentProduct = 6;
                    break;
                case "button18":
                    currentProduct = 7;
                    break;

            }
            return currentProduct;
        }
    }
}
