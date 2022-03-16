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


        [HttpGet("Get/{id}")]
        public IActionResult Get(int Id)
        {
            var cevap = db.Kisiler.Find(Id);
            return Json(cevap);
        }

        [HttpPost("Post")]
        public IActionResult Post(Kisi nesne)
        {
            nesne.IsActive = true;
            db.Kisiler.Add(nesne);
            db.SaveChanges();
            return Json("");
        }

        [HttpPut("Put")]
        public IActionResult Put(Kisi nesne)
        {
            nesne.IsActive = true;
            db.Kisiler.Update(nesne);
            db.SaveChanges();
            return Json("");
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(List<int> id)
        {
            foreach (var item in id)
            {
                Kisi nesne = db.Kisiler.Find(item);
                nesne.IsActive = false;
                db.Kisiler.Update(nesne);
            }

            db.SaveChanges();
            return Json("");
        }
    }
}
