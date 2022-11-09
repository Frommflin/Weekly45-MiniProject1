using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W45_Mini1
{
    internal class Laptop : Hardware
    {
        /*  
         *  --------------------------------------------
         *  ---             Level 1-2                ---
         *  --------------------------------------------
        */
        /*
        public Laptop(string type, string brand, string model, int price, DateTime purchased)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Price = price;
            DateOfPurchase = purchased;
        }
        */

        /*  
         *  --------------------------------------------
         *  ---              Level 3                 ---
         *  --------------------------------------------
        */
        public Laptop(string type, string brand, string model, int price, DateTime purchased, Office office)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Price = price;
            DateOfPurchase = purchased;
            Office = office;
        }
    }
}
