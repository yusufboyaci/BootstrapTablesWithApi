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
        public void Post(AdresDefteri nesne)
        {
            nesne.IsActive = true;
            db.AdresDefterleri.Add(nesne);
            db.SaveChanges();
        }

        [HttpPut("Put")]
        public void Put(AdresDefteri nesne)
        {
            nesne.IsActive = true;
            db.AdresDefterleri.Update(nesne);
            db.SaveChanges();
        }

        [HttpDelete("Delete")]
        public void Delete(List<int> id)
        {
            foreach (var item in id)
            {
                AdresDefteri nesne = db.AdresDefterleri.Find(item);
                nesne.IsActive = false;
                db.AdresDefterleri.Update(nesne);
            }
            db.SaveChanges();
        }
    }
}
