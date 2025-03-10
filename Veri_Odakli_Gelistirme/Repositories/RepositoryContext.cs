﻿using Microsoft.EntityFrameworkCore;
using Entities.Models;
using System.Reflection.Emit;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModuleBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product() { ProductId = 1, ProductName = "Computer", Price = 17_000 },
                new Product() { ProductId = 2, ProductName = "Keyboard", Price = 1000 },
                new Product() { ProductId = 3, ProductName = "Mouse", Price = 500 },
                new Product() { ProductId = 4, ProductName = "Monitor", Price = 7000 },
                new Product() { ProductId = 5, ProductName = "Deck", Price = 1500 }
            );
        }

        internal IQueryable<T> Set<T>()
        {
            throw new NotImplementedException();
        }
    }

}