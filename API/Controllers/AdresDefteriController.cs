using API.Models.Context;
using API.Models.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdresDefteriController : Controller
    {
        private readonly AppDbContext db;
        public AdresDefteriController(AppDbContext context)
        {
            db = context;
        }
        [HttpGet("Get")]
        public IActionResult Get()
        {
            return Json(db.AdresDefterleri.Where(x => x.IsActive == true).ToList());
        }
        [HttpGet("KisiVeAdresDefteriTablosu")]
        public IActionResult KisiVeAdresDefteriTablosu()
        {
            return Json(db.KisiVeAdresDefteriTablosu.Where(x => x.IsActive == true).ToList());
        }

        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            return Json(db.AdresDefterleri.Find(id));
        }
        /// <summary>
        /// Kişilerin id lerini getiren metot tur.Şuan kullanılmıyor.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetirList")]
        public IActionResult GetirList()
        {

            return Json(db.AdresDefterleri.Where(x => x.IsActive == true).Select(x => x.KisiId).ToList());

        }
        /// <summary>
        /// Şu an kullanılmıyor.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("VInsanlarList/{id}")]
        public IActionResult VInsanlarList(int id)
        {
            return Json(db.Insanlar.Where(x => x.KisiId == id).ToList());

        }

        [HttpPost("Post")]
        public IActionResult Post(AdresDefteri nesne)
        {
            nesne.IsActive = true;
            db.AdresDefterleri.Add(nesne);
            db.SaveChanges();
            return Json("");
        }

        [HttpPut("Put")]
        public IActionResult Put(AdresDefteri nesne)
        {
            nesne.IsActive = true;
            db.AdresDefterleri.Update(nesne);
            db.SaveChanges();
            return Json("");

        }

        [HttpDelete("Delete")]
        public IActionResult Delete(List<int> id)
        {
            foreach (var item in id)
            {
                AdresDefteri nesne = db.AdresDefterleri.Find(item);
                nesne.IsActive = false;
                db.AdresDefterleri.Update(nesne);
            }
            db.SaveChanges();
            return Json("");
        }
    }
}
