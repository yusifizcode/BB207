using Microsoft.AspNetCore.Identity;

namespace Eflyer.Core.Models;

public class AppUser : IdentityUser
{
    public string FullName { get; set; }
}
