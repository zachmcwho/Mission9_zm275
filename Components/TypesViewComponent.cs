﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission9_zm275.Models;

namespace Mission9_zm275.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private IBookstoreRepository repo { get; set; }
        public TypesViewComponent(IBookstoreRepository temp)
        {
           repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTypes = RouteData?.Values["projectType"];

            var types = repo.Book.Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(types);
        }
    }

    
}
