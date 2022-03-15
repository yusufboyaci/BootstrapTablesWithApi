using API.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Context
{
    public class AppDbContext : DbContext
    {
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }
        public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<AdresDefteri> AdresDefterleri { get; set; }
        public DbSet<Login> Loginler { get; set; }
        
    }
}
