using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission9_zm275.Models;

namespace Mission9_zm275.Controllers
{
    public class PurchasesController : Controller
    {

        public PurchasesController()
        {

        }
        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Purchase());
        }
        [HttpPost]
        public IActionResult Checkout(Purchase purchase)
        {
            
        }
    }
}
