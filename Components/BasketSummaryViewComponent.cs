using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission9_zm275.Models;
namespace Mission9_zm275.Components
{
    public class BasketSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public BasketSummaryViewComponent(Basket basketService)
        {
            basket = basketService;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
    
}
