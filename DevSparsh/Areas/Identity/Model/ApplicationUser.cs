using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DevSparsh.Areas.Identity.Model
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MinLength(4)]
        [MaxLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(50)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Mobile Number is required")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid phone number format")]
        [Display(Name = "Mobile Number")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile Number must be exactly 10 digits")]
        public string MobileNo { get; set; }
    }
}
