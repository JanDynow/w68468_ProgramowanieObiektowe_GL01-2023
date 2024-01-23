using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    class Person: Interface.Ientity<long>, Interface.IHasCreationTime
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age  { get; set; }
        public List<Book> BorrowedBook { get; set; } = new List<Book>();
    }
}
