using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace Farmer_s_Hub.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "User name")]
        public string Username { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [PasswordPropertyText]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [ForeignKey("User")]
        [Required]
        public Role Role { get; set; }

        public UserStatus Status { get; set; }

        public ICollection<Product> Products { get; set; }
    }

    public enum UserStatus
    {
        Submitted,
        Approved,
        Rejected
    }
}
