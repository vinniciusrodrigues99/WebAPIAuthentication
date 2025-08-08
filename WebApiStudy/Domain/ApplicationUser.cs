using Microsoft.AspNetCore.Identity;

namespace WebApiStudy.Domain;

public class ApplicationUser : IdentityUser
{
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpiration { get; set; } 
}