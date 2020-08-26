using System;
using EfExerciseASPNET.Models;
using Microsoft.EntityFrameworkCore;

namespace EfExerciseASPNET.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options){}

        //RetrieveConnectionString retrieve = new RetrieveConnectionString();

        public DbSet<Book> Book { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Rent> Rent { get; set; }
        public DbSet<Category> Category { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}