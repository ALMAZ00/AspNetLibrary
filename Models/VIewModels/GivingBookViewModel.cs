using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models.VIewModels
{
    public class GivingBookViewModel
    {
        public Book Book { get; set; }
        public Reader Reader { get; set; }
        public int BookId => Book.Id;
        public int ReaderId => Reader.Id;
        public GivingBookViewModel(Book book, Reader reader)
        {
            Book = book;
            Reader = reader;
        }
    }
}
