using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library.Models
{

    [Table("BorrowedBooks2")]
    public class BorrowedBook : IEntity<long>, IHasCreationTime
    {
        [Key]
        public long Id { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;

        public int BookId { get; set; }
        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }

        public long PersonId { get; set; }
        public Person Person { get; set; }
    }
}
