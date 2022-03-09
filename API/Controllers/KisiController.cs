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
    public class KisiController : Controller
    {
        private readonly AppDbContext db;
        public KisiController(AppDbContext context)
        {
            db = context;
        }
        [HttpGet("Get")]
        public IActionResult Get()
        {
            List<Kisi> kisiler = db.Kisiler.Where(x => x.IsActive == true).ToList();
            return Json(kisiler);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json(db.Kisiler.Find(id));
        }
        [HttpPost("Post")]
        public void Post(Kisi nesne)
        {
            nesne.IsActive = true;
            db.Kisiler.Add(nesne);
            db.SaveChanges();
        }


        [HttpPut("Put/{id}")]
        public void Put(int id)
        {
            db.Kisiler.UpdateRange(db.Kisiler.Find(id));
            db.SaveChanges();
        }

        [HttpDelete("Delete")]
        public void Delete(List<int> id)
        {
            foreach (var item in id)
            {
                Kisi nesne = db.Kisiler.Find(item);
                nesne.IsActive = false;
                db.Kisiler.Update(nesne);
            }
           
            db.SaveChanges();
        }
    }
}
