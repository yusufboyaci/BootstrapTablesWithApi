using API.Models.Context;
using API.Models.Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly AppDbContext db;
        public LoginController(AppDbContext context)
        {
            db = context;
        }
        private bool LoginUser(string username, string password)
        {
            Login kullanici = db.Loginler.Where(x => x.IsActive == true).FirstOrDefault(x => x.Username == username && x.Password == password);
            if (kullanici != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (LoginUser(login.Username, login.Password))
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,login.Username),
                };
                ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal userPrincipal = new ClaimsPrincipal(userIdentity);
                Login kisi = db.Loginler.Where(x => x.Username == login.Username && x.Password == login.Password && x.IsActive == true).FirstOrDefault() ?? throw new Exception("Böyle bir kullanıcı bulunmamaktadır.");
                await HttpContext.SignInAsync(userPrincipal);
                return Json(true);
            }
            return Json(false);
        }
        [HttpPost("Logout")]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return Json(true);
        }

        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            return Json(db.Loginler.Find(id));
        }
        [HttpPost("Post")]
        public IActionResult Post(Login nesne)
        {
            nesne.IsActive = true;
            db.Loginler.Add(nesne);
            db.SaveChanges();
            return Json("Ekleme yapıldı");
        }
        [HttpPut("Put")]
        public IActionResult Put(Login nesne)
        {
            nesne.IsActive = true;
            db.Loginler.Update(nesne);
            db.SaveChanges();
            return Json("Guncelleme yapıldı");
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(List<int> id)
        {
            foreach (var item in id)
            {
                Login nesne = db.Loginler.Find(item);
                nesne.IsActive = false;
                db.Loginler.Update(nesne);
            }
            db.SaveChanges();
            return Json("Kayit Silindi");
        }
    }
}
