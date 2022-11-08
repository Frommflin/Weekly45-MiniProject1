﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W45_Mini1
{
    internal class Phone : Hardware
    {
        public Phone(string type, string brand, string model, int price, DateTime purchased)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Price = price;
            DateOfPurchase = purchased;
        }
    }
}