using Microsoft.AspNetCore.Mvc;
using Mission9_Tschen02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_Tschen02.Components
{
    public class TypesViewComponent: ViewComponent
    {
        private IBookProjectRepository repo { get; set; }

        public TypesViewComponent (IBookProjectRepository temp)
        {
            repo = temp;
        }
        public  IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["projectHi"];
            var types = repo.Books.Select(x => x.Category).Distinct().OrderBy(x => x);

            return View(types);
        }
    }
}
