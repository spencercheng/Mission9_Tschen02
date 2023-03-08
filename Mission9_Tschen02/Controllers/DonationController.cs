using Microsoft.AspNetCore.Mvc;
using Mission9_Tschen02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_Tschen02.Controllers
{
    public class DonationController : Controller
    {
        public IActionResult Index()
        {
            return View(new Donation());
        }
    }
}
