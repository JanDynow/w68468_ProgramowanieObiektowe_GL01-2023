using Library.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    class Book : Ientity<int>, Interface.IHasCreationTime
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Title { get; set; }
        public string Autor { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
