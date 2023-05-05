using domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.Emit;

namespace context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions <Context> options) : base(options)
        {
            
        }
        public DbSet<Category> Catigoes { get; set; }
        public DbSet<images> imagess { get; set; }
        public DbSet<Product> Productss { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }

    }
}