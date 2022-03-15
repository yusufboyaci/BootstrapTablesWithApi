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

        private bool LoginUser(string username, string password)
        {

            return true;
        }
       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM nesne)
        {
            if (LoginUser(nesne.Username,nesne.Password))
            {
                return View();
            }
            return View();
        }
    }
}
