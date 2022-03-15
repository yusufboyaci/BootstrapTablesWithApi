using API.Models.Context;
using API.Models.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly AppDbContext db;
        public LoginController(AppDbContext context)
        {
            db = context;
        }
        [HttpGet("Get")]
        public IActionResult Get()
        {
            List<Login> loginler = db.Loginler.Where(x => x.IsActive == true).ToList();
            return Json(loginler);
        }
        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            return Json()
        }
    }
}
