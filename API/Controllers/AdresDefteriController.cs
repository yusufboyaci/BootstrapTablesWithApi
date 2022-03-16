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

        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            return Json(db.AdresDefterleri.Find(id));
        }

        [HttpGet("GetirList")]
        public IActionResult GetirList()
        {

            return Json(db.AdresDefterleri.Where(x => x.IsActive == true).Select(x => x.KisiId).ToList());

        }

        [HttpGet("VInsanlarList/{id}")]
        public IActionResult VInsanlarList(int id)
        {
            List<V_Kisi> a = db.Insanlar.Where(x => x.KisiId == id).ToList();
            return Json(a);
            //return Json(db.AdresDefterleri.Where(x => x.IsActive == true).ToList().Select(x => x.KisiId));

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
