

namespace DoveTailQ1.Models
{
    using System.ComponentModel.DataAnnotations;
    public class RegisterViewModel
    {
        [Display(Name = "First Name :")]
        [Required(ErrorMessage = "First Name is required.")]
        [MinLength(5, ErrorMessage = "First name should have minimum lenght 5")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name :")]
        [Required(ErrorMessage = "Last Name is required.")]
        [MinLength(5, ErrorMessage = "Last name should have minimum lenght 5")]
        public string LastName { get; set; }

        [Display(Name = "Mobile Number :")]
        [Required(ErrorMessage = "Mobile number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid mobile number.")]
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
    }
}
