using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public class Reader
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Birthday { get; set; }
    }
}
