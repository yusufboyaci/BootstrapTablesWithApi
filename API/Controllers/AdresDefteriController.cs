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
        // GET: api/<AdresDefteriController>
        [HttpGet]
        public IActionResult Get()
        {
            return Json(db.AdresDefterleri.Where(x => x.IsActive == true).ToList());
        }

        // GET api/<AdresDefteriController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json(db.AdresDefterleri.Find(id));
        }

        // POST api/<AdresDefteriController>
        [HttpPost]
        public void Post(AdresDefteri nesne)
        {
            db.AdresDefterleri.Add(nesne);
        }

        // PUT api/<AdresDefteriController>/5
        [HttpPut("{id}")]
        public void Put(int id)
        {
            db.AdresDefterleri.Update(db.AdresDefterleri.Find(id));
        }

        // DELETE api/<AdresDefteriController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            AdresDefteri nesne = db.AdresDefterleri.Find(id);
            nesne.IsActive = false;
            db.AdresDefterleri.Update(nesne);
        }
    }
}
