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
    public class KisiController : Controller
    {
        private readonly AppDbContext db;
        public KisiController(AppDbContext context)
        {
            db = context;
        }
        // GET: api/<KisiController>
        [HttpGet]
        public IActionResult Get()
        {
            return Json(db.Kisiler.Where(x => x.IsActive == true));
        }

        // GET api/<KisiController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json(db.Kisiler.Find(id));
        }

        // POST api/<KisiController>
        [HttpPost]
        public void Post(Kisi nesne)
        {
            db.Kisiler.Add(nesne);
        }

        // PUT api/<KisiController>/5
        [HttpPut("{id}")]
        public void Put(int id)
        {
            db.Kisiler.Update(db.Kisiler.Find(id));
        }

        // DELETE api/<KisiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Kisi nesne = db.Kisiler.Find(id);
            nesne.IsActive = false;
            db.Kisiler.Update(nesne);
        }
    }
}
