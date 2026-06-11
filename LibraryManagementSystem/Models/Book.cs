using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public string BookCode { get; set; }
        public string BookTitle { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
}