using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
 *  --------------------------------------------
 *  ---              Level 3                 ---
 *  --------------------------------------------
*/
namespace W45_Mini1
{
    internal class Office
    {
        public Office(string country, string localCurrency, double currencyValue)
        {
            Country = country;
            LocalCurrency = localCurrency;
            CurrencyValue = currencyValue;
        }

        public string Country { get; set; }
        public string LocalCurrency { get; set; }
        public double CurrencyValue { get; set; }
    }
}
