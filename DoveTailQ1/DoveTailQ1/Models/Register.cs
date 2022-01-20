

namespace DoveTailQ1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class Register
    {
        [Display(Name = "First Name :")]
        [Required(ErrorMessage = "First name is required.")]
        [MinLength(5, ErrorMessage = "First Name Should have min Lenght 5")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name :")]
        [Required(ErrorMessage = "Last Name is required.")]
        [MinLength(5, ErrorMessage = "First Name Should have min Lenght 5")]
        public string LastName { get; set; }

        [Display(Name = "Mobile Number:")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
    }
}
