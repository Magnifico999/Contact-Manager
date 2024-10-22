using Microsoft.AspNetCore.Identity;

namespace Contact.Api.Models
{
    public class UserProfile : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePicture { get; set; } 
    }
}
