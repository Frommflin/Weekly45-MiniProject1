using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W45_Mini1
{
    internal class Hardware
    {
        /*  
         *  --------------------------------------------
         *  ---             Level 1-2                ---
         *  --------------------------------------------
        */
        public string Type { get; set; } // Stationary Computer, Laptop, Phone etc.
        public string Brand { get; set; }  // Lenovo, Apple etc.
        public string Model { get; set; } // iPhone 10, S22 etc.
        public int Price { get; set; } // In USD
        public DateTime DateOfPurchase { get; set; }

        /*  
         *  --------------------------------------------
         *  ---              Level 3                 ---
         *  --------------------------------------------
        */
        public Office Office { get; set; }
    }
}
