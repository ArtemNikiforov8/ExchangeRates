using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ExchangeRates.Models
{
    public class CurrenciesContext : ICurrenciesContext
    {
        WebClient client;
        Currencies currencies;

        public CurrenciesContext()
        {
            client = new WebClient();
            String dowString = client.DownloadString(new Uri("https://www.cbr-xml-daily.ru/daily_json.js"));
            currencies = JsonConvert.DeserializeObject<Currencies>(dowString); 
        }

        public IEnumerable<Currency> GetAll()
        {
            return currencies.Valute.Values;
        }
    }
}
