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

        [HttpGet("{id}")]
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

        [HttpPut("{id}")]
        public void Put(int id)
        {
            db.AdresDefterleri.Update(db.AdresDefterleri.Find(id));
            db.SaveChanges();
        }

        [HttpDelete("Delete/{id}")]
        public void Delete(int id)
        {
            AdresDefteri nesne = db.AdresDefterleri.Find(id);
            nesne.IsActive = false;
            db.AdresDefterleri.Update(nesne);
            db.SaveChanges();
        }
    }
}
