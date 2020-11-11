using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeRates.Models
{
    public interface ICurrenciesContext
    {
        public IEnumerable<Currency> GetAll();
    }
}
