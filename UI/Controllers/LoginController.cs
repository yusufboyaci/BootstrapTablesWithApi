using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login() => View();
        [HttpPost]
        public IActionResult Login(int id)
        {           
            return RedirectToAction("Index","Kisi");
        }
    }
}
