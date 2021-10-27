﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data
{
    public class DemoContext : DbContext
    {
        //public DemoContext()
        //{
        //}
        //public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = localhost; database = DemoNetby; Trusted_Connection = true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; }

        //public DemoContext(DbContextOptions options) : base(options)
        //{
        //}

        //public DbSet<Product> Products { get; set; }
    }
}
