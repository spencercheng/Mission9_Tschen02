using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission9_Tschen02.Models;
using Mission9_Tschen02.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_Tschen02.Controllers
{
    public class HomeController : Controller
    {


        private IBookProjectRepository repo;

        public HomeController (IBookProjectRepository temp)
        {
            repo = temp;
        }
        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;
            var x = new ProjectsViewModel
            {
                Books = repo.Books.OrderBy(p => p.Title).Skip((pageNum - 1) * pageSize).Take(pageSize),
                PageInfo = new PageInfo
                {
                    TotalNumProjects = repo.Books.Count(),
                    ProjectsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };
            
            return View(x);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
