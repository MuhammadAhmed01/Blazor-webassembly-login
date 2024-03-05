using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace BlazorApp.Models.Account
{
    public class AddUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //[Required]
        //public string FirstName { get; set; }

        //[Required]
        //public string LastName { get; set; }

        [Required]
        [Display(Name = "Username")] // comment out later if needed
        public string Username { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "The Password field must be a minimum of 6 characters")]
        public string Password { get; set; }

        [Required]
        // [CompareProperty("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}