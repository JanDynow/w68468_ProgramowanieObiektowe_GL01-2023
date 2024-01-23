using Library.Context;
using Library.Interfaces;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Repositories
{
    public class PersonRepository: IPersonRepository
    {
        private LibraryDbContext _dbContext;

        public PersonRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void BorrowBook(long id, int bookId)
        {
            _dbContext.BorrowedBooks.Add(new BorrowedBook() {BookId = bookId, PersonId = id });
        }

        public void Create(Person item)
        {
            _dbContext.Persons.Add(item);
            _dbContext.SaveChanges();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Person Get(long id)
        {
            return _dbContext.Persons.FirstOrDefault(x => x.Id == id);
        }

        public List<Person> GetAll()
        {
            return _dbContext.Persons.ToList();
        }

        public List<Book> GetBorrowedBook(long id)
        {
            return _dbContext.Persons.Include(x => x.BorrowedBooks).ThenInclude(x=> x.Book).SelectMany(x=> x.BorrowedBooks.Select(b=> b.Book)).ToList();
        }

        public void Update(Person item)
        {
            _dbContext.Update(item);
            _dbContext.SaveChanges();
        }
    }
}
