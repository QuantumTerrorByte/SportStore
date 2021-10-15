﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportStore.Models.Interfaces;
using SportStore.Models.ProductModel;

namespace SportStore.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<CartLine> CartLines { get; set; }

    }
}