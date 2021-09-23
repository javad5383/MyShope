﻿using System;
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
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<ProductColors> ProductColors { get; set; }
        public DbSet<UserFavorites> UserFavorites { get; set; }
        public DbSet<Specifications> Specifications { get; set; }
        public DbSet<Titles> Titles { get; set; }
        

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            
        //   base.OnModelCreating(modelBuilder);
        //}




    }


}
