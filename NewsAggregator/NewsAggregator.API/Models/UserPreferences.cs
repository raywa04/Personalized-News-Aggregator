public class UserPreferences
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
    public string PreferredCategories { get; set; }
    public string Keywords { get; set; }
}
