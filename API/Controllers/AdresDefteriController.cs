using API.Models.Context;
using API.Models.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
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
