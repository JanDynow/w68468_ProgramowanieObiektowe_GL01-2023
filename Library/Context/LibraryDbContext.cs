using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Context
{
    public class LibraryDbContext: DbContext
    {
        private readonly string DbPath = "C:\\Users\\dkontek\\Desktop\\Programowanie_obiektowe_3IID-2022-GL01\\Lab\\Lab7\\library.db";


        public DbSet<Book> Books { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}
