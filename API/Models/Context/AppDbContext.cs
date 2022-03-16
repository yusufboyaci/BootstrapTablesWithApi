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
        public DbSet<V_Kisi> Insanlar { get; set; }//database de oluşturulan view bu şekilde tanıtılır.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<V_Kisi>().ToView("Insanlar").HasNoKey();//database de oluşturulan view bu şekilde tanıtılır.
            base.OnModelCreating(modelBuilder); 
        }

    }
}
