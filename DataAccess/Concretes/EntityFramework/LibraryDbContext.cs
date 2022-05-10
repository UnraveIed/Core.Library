using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concretes.EntityFramework
{
    public class LibraryDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=LastLibraryDb; Trusted_Connection=true");
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Library> Libraries { get; set; }

        public DbSet<MyBookList> MyBookLists { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
