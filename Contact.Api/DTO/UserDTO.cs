using System.ComponentModel.DataAnnotations;

namespace Contact.Api.DTO
{
    public class UserDTO
    {
        [Required]
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
