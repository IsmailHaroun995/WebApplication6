using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Emps
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        //[Display(ResourceType = typeof(System.Resources.ResourceSet), Name = nameof(Resources.ModelValidation.UserName))]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime OnTimeCreated { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        [EmailAddress]
        //[Remote("CheckExistingEmail", "Employee", ErrorMessage = "Email already exists!")]
        public string Email { get; set; }


        [Required]
        public string Mobile { get; set; }


        [Required]
        [MaxLength(20)]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        //[Remote] 
        public string UserName { get; set; }



        [Required]
        [MaxLength(20)]
        [MinLength(7)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        //[Required]

        public int DepartmentId { get; set; }
        public List<Department> Department { get; set; }

        public string DirectManager { get; set; }

        public bool IsDeleted { get; set; }
    }
}
