using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class USDCurrency : ICurrency
    {
        public string CurrencyName => "US dollar";

        public double CurrencyRate => 0.85;
    }
}
