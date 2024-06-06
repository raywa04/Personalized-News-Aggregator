using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public UserPreferences Preferences { get; set; }
}
