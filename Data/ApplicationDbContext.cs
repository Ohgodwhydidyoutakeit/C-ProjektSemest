using Microsoft.EntityFrameworkCore;
using Stamps.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stamps.Data
{
    /// <summary>
    ///  Creating Context via inheritance 
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Ensure database creation 
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        /// <summary>
        ///  Getting Entities 
        /// </summary>
        public DbSet<Product> Products { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Stamp> Stamps { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().HasData(GetProducts()); 
            base.OnModelCreating(modelBuilder);
        }



 
    }
}
