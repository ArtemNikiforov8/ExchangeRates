using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ExchangeRates.Models;
using System;

namespace ExchangeRates.Controllers
{
    [ApiController]
    public class CurrenciesController : Controller
    {
        public CurrenciesController(ICurrenciesContext Valutes)
        {
            this.Valutes = Valutes;
        }

        [Route("currencies")]
        [HttpGet]
        public IActionResult Get(Int32 PageNumber = 1)
        {
            Int32 pageSize = 5;
            PageViewModel viewModel = new PageViewModel(Valutes.GetAll().Count(), PageNumber, 5);
            IEnumerable<Currency> currenciesPerPage = Valutes.GetAll().Skip((PageNumber - 1) * pageSize).Take(pageSize);
            IndexViewModel indexViewModel = new IndexViewModel(currenciesPerPage, viewModel);
            return View(indexViewModel);
        }

        [Route("currency/{ID}")]
        [HttpGet]
        public IActionResult GetById(String ID)
        {
            Currency valute = Valutes.GetAll().FirstOrDefault(x => x.ID == ID);
            if (valute == null)
                return NotFound();
            return View(valute);
        }

        public ICurrenciesContext Valutes { get; set; }
    }
}
