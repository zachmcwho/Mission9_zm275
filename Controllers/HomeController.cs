using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission9_zm275.Models;
using Mission9_zm275.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_zm275.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository repo;

        public HomeController (IBookstoreRepository temp)
        {
            repo = temp;
        }
            


        public IActionResult Books()
        {
           
            return View();
        }

        public IActionResult Index(string projectType, int pageNum = 1)
        {
            int pageSize = 10;
            var x = new BookstoreViewModel
            {
                Books = repo.Book.OrderBy(p => p.Title)
                .Where(p => p.Category == projectType || projectType == null)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),
                PageInfo = new PageInfo
                {
                    TotalNumBooks = (projectType == null ? 
                    repo.Book.Count() : repo.Book.Where(x => x.Category == projectType).Count()),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };
            //change page size if there arent enough books
            //if (x.PageInfo.TotalNumBooks < x.PageInfo.BooksPerPage)
            //{
            //    x.PageInfo.BooksPerPage = x.PageInfo.TotalNumBooks;
            //    x.Books = repo.Book.OrderBy(p => p.Title).Take(x.PageInfo.TotalNumBooks);
            //}

            return View(x);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
