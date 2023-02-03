using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture URL is required !")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required !")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 100 characters !")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required !")]
        [StringLength(200, MinimumLength = 30, ErrorMessage = "Biography must be between 30 and 200 characters !")]
        public string Bio { get; set; }

        //public Person(int id, string profilePictureURL, string fullName,string bio)
        //{
        //    Id= id;
        //    ProfilePictureURL= profilePictureURL;
        //    FullName= fullName;
        //    Bio= bio;
        // }
    }
}
