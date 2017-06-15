using Studio60.Demo.ViewModels.Validators;
using System;
using System.ComponentModel.DataAnnotations;

namespace Studio60.Demo.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "The first name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "The day is required")]
        [RegularExpression("\\d+", ErrorMessage = "The value {0} is invalid day")]
        [Range(1, 31, ErrorMessage = "The value {0} is invalid day")]
        [DOBFieldAttribute(ErrorMessage = "The value {0} is invalid day")]
        public int DOBDay { get; set; }

        [Required(ErrorMessage = "The month is required")]
        [RegularExpression("\\d+", ErrorMessage = "The value {0} is invalid month")]
        [Range(1, 12, ErrorMessage = "The value {0} is invalid month")]
        [DOBFieldAttribute(ErrorMessage = "The value {0} is invalid month")]
        public int DOBMonth { get; set; }

        [Required(ErrorMessage = "The year is required")]
        [RegularExpression(@"^(19|20)\d{2}$", ErrorMessage = "The value {0} is invalid year")]
        [DOBFieldAttribute(ErrorMessage = "The value {0} is invalid year")]
        public int DOBYear { get; set; }

        [DOB(ErrorMessage = "The date of birth must be a valid date and over 18 years old")]
        public DateTime DateOfBirth { get; set; }
    }
}