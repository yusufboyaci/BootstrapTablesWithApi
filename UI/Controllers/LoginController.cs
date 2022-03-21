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
            if (id == 0)
            {
                throw new Exception("Kullanıcı adınız ve şifreniz hatalıdır ");
            }
            return RedirectToAction("Index","Kisi");
        }
    }
}
