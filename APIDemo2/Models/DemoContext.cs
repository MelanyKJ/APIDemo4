using Microsoft.EntityFrameworkCore;
using System;
using APIDemo2.Models;

namespace APIDemo2.Models
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Invoice> Invoice { get; set; }


    }
}
