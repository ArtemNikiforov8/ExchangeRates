using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeRates.Models
{
    public class PageViewModel
    {
        public Int32 PageNumber { get; set; }
        public Int32 TotalPages { get; set; }

        public PageViewModel(Int32 Count, Int32 PageNumber, Int32 PageSize)
        {
            this.PageNumber = PageNumber;
            TotalPages = (Int32)Math.Ceiling(Count / (double)PageSize);
        }

       
    }
}
