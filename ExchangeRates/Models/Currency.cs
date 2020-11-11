using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeRates.Models
{
    public class Currency
    {
        public String ID { get; set; }
        public String NumCode { get; set; }
        public String CharCode { get; set; }
        public Int32 Nominal { get; set; }
        public String Name { get; set; }
        public Double Value { get; set; }
        public Double Previous { get; set; }

    }
}
