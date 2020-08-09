using System; 
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    
    {
        [Required (ErrorMessage="First Name required")]
        [MinLength(4, ErrorMessage= "Must have a minimum length of 4 characters")]
        [Display(Name = "First Name:")] 
        public string FirstName { get; set; }
        [Required (ErrorMessage="Last Name required")]
        [MinLength(4, ErrorMessage= "Must have a minimum length of 4 characters")]
        [Display(Name = "Last Name:")] 
        public string LastName { get; set; }
        [Required (ErrorMessage="Age required")]
        [Range(1, 130, ErrorMessage = "Only positive number allowed")]
        public int Age { get; set; }
        [Required (ErrorMessage="Email required")]
        [EmailAddress]
        public string Email{ get; set; }
        [Required (ErrorMessage="Password required")]
        [MinLength(8, ErrorMessage= "Must have a minimum length of 8 characters")]
        [DataType(DataType.Password)]
        public string Password{ get; set; }

    
    }
    
}