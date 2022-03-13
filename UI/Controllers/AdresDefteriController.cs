using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class AdresDefteriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create() => View();
           
        public IActionResult Edit() => View();
    }
}
