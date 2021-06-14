using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSO_LF089.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Display(Name = "Book Name")]
        public string BookName { get; set; }
        [Display(Name = "Subject")]
        public string BookSubject { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        [Display(Name = "Status")]
        public string ReadingStatus { get; set; }
        public string Image { get; set; }
    }
}
