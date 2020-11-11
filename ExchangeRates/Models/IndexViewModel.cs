using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeRates.Models
{
    public class IndexViewModel
    {
        public IndexViewModel(IEnumerable<Currency> Currencies, PageViewModel ViewModel)
        {
            this.Currencies = Currencies;
            PageViewModel = ViewModel;
        }
        public IEnumerable<Currency> Currencies {get;set;}
        public PageViewModel PageViewModel { get; set; }
    }
}
