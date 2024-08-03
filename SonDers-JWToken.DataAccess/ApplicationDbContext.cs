using Microsoft.EntityFrameworkCore;
using SonDers_JWToken.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonDers_JWToken.DataAccess
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Brand>Brand { get; set; }
        public DbSet<Model> Model { get; set; }
        public DbSet<Car> Car { get; set; }

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
