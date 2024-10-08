using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Blog.Models
{
   public class Author
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Birth date is required")]
        [Display(Name = "Date of Birth")]
        public DateTime BirthDate { get; set; }
        public string FormattedBirthDate => BirthDate.ToString("M/d/yyyy");

        [Required(ErrorMessage = "Gender is required")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Salary is required")]   
        public string? Salary { get; set; }



        [Required]
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public Department? Department { get; set; }

        public ICollection<Post>? Posts { get; set; }
    }
}

