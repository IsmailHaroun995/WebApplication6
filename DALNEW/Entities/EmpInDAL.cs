using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class EmpInDAL
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime dateTime { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        [MaxLength(20)]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        //[Remote
        public string UserName { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(20)]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [Required]

        //public Department department { get; set; }

        public string DirectManager { get; set; }
    }
}
