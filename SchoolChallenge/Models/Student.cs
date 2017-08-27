using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolChallenge.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Does this Student have a Scholarship?")]
        public bool HasScholarship { get; set; }
    }
}
