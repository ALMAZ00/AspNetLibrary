using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models.VIewModels
{
    public class IssueViewModel
    {
        public string ReaderName { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public DateTime IssueDate { get; set; }
        public IssueViewModel(Book book, Reader reader, BookIssue issue)
        {
            ReaderName = reader.FullName;
            BookName = book.Name;
            BookAuthor = book.Author;
            IssueDate = issue.IssueDate;
        }
    }
}
