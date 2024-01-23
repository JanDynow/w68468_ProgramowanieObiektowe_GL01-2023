using Library.Context;
using Library.Interfaces;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Repositories
{
    public class BookRepository : IBookRepository
    {
        private LibraryDbContext _dbContext;

        public BookRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Book item)
        {
            using (var dbContext = new LibraryDbContext())
            {
                dbContext.Books.Add(item);
                dbContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(x => x.Id == id);
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }

        public Book Get(int id)
        {
           return _dbContext.Books.FirstOrDefault(x => x.Id == id);
        }

        public List<Book> GetAll()
        {
            return _dbContext.Books.ToList();
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return _dbContext.Books.Where(x => x.Author.ToLower().Contains(author.ToLower())).ToList();
        }

        public List<Book> GetBooksByPublishYear(int year)
        {
            return _dbContext.Books.Where(x => x.PublishYear == year).ToList();
        }

        public void Update(Book item)
        {
            _dbContext.Books.Update(item);
            _dbContext.SaveChanges();
        }
    }
}
