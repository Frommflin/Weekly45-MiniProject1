using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W45_Mini1
{
    internal class Hardware
    {
        public string Type { get; set; } // Stationary Computer, Laptop, Phone etc.
        public string Brand { get; set; }  // Lenovo, Apple etc.
        public string Model { get; set; } // iPhone 10, S22 etc.
        public int Price { get; set; } // In USD? Decide!!!!!
        public DateTime DateOfPurchase { get; set; }
    }
}
