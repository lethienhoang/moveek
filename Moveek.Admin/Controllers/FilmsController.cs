using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moveek.Admin.Controllers
{
    public class FilmsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }

        public IActionResult Rating()
        {
            return View();
        }
    }
}
