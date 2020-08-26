using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfExercise2.Models
{
    public class Context : DbContext
    {
        public DbSet<Book> Book{ get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Rent> Rent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            RetrieveConnectionString Retrieve = new RetrieveConnectionString();

            optionsBuilder.UseSqlServer(Retrieve.GetConnectionString());
        }
    }
}
