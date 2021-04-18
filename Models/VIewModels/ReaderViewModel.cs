using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models.VIewModels
{
    public class ReaderViewModel
    {
        public Reader Reader { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public ReaderViewModel(Reader reader, IEnumerable<Book> books)
        {
            Reader = reader;
            Books = books;
        }
    }
}
