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
            return Json(db.Kisiler.Find(Id));
        }

        [HttpPost("Post")]
        public void Post(Kisi nesne)
        {
            nesne.IsActive = true;
            db.Kisiler.Add(nesne);
            db.SaveChanges();
        }

        [HttpPut("Put")]
        public void Put(Kisi nesne)
        {
            nesne.IsActive = true;
            db.Kisiler.Update(nesne);
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
