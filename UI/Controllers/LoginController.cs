using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login() => View();
        [HttpPost]
        public IActionResult Login(LoginVM nesne)
        {
            //List<Claim> claims = new List<Claim>
            //{
            //    new Claim(ClaimTypes.Name,nesne.Username)
            //};
            //ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
            //ClaimsPrincipal userPrincipal = new ClaimsIdentity(userIdentity);

           // return RedirectToAction("Index", "Kisi");
            return Json(nesne);
        }
    }
}
