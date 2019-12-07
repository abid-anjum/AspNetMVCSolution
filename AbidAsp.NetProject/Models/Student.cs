using System;
using System.ComponentModel.DataAnnotations;

namespace AbidAsp.NetProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }
        public Standard standard { get; set; }
    }
}
