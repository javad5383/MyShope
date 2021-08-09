using System;
using JShope.Models;
using Microsoft.EntityFrameworkCore;

namespace MyEshop.Data
{

    public class JShopeContext:DbContext
    {
        public JShopeContext(DbContextOptions<JShopeContext> options) : base(options)
        {

        }


        public DbSet<Category> Categories { get; set; }

        public DbSet<Group> Groups { get; set; }
        public DbSet<SubGroup> SubGroups { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Brands> Brands { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            
        //   base.OnModelCreating(modelBuilder);
        //}




    }


}
