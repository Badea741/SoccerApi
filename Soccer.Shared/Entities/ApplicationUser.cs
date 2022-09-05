using Microsoft.AspNetCore.Identity;

namespace Soccer.Shared.Entities;
public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
}