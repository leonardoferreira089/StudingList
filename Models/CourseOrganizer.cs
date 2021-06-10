using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSO_LF089.Models
{
    public class CourseOrganizer
    {
        public int Id { get; set; }
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
        public string Subjects { get; set; }
        [Display(Name = "Course Duration")]
        public int CourseDuration { get; set; }
        public string Status { get; set; }
        public string Localization { get; set; }
        [Display(Name = "Purchased")]
        public bool purchased { get; set; }
    }
}
