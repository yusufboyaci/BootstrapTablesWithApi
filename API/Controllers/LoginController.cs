using API.Models.Context;
using API.Models.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        
        [HttpGet("Login")]
        public IActionResult Login(string username, string password)
        {
            Login kullanici = db.Loginler.FirstOrDefault(x => x.IsActive == true && x.Username == username && x.Password == password);
            return Json(kullanici);
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
