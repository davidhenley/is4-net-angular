using Microsoft.AspNetCore.Identity;

namespace AuthServer.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
    }
}