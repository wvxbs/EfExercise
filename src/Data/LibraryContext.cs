using System;
using EfExercise.src.Models;
using Microsoft.EntityFrameworkCore;

namespace EfExercise.src.Data
{
    class LibraryContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Rent> Rent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}