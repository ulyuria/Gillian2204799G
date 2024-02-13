using Microsoft.AspNetCore.Identity;

namespace Gillian2204799G.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
    }
}
