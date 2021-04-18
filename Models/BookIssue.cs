using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public class BookIssue
    {
        public int Id { get; set; }
        public int BookID { get; set; }
        public int ReaderId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime IssueDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? ReturnDate { get; set; }
    }
}
