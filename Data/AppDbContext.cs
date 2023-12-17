using System;
using FluentBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentBlazor.Data
{
    public class AppDbContext:DbContext
    {
            public AppDbContext(DbContextOptions<AppDbContext> options ):base(options)
            {
                
            }

            public DbSet<Customer> Customers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer{Id=1,Name="Alley",Email="alley@gmail.com"},
                new  Customer {Id=2,Name="Bob", Email="bob@gmail.com"}
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
