using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class EUROCurrency : ICurrency
    {
        public string CurrencyName => "Euro";

        public double CurrencyRate => 1;
    }
}
