public class UserSessionService
{
    public string CurrentUserName { get; set; }
    public List<int> RegisteredEventIds { get; set; } = new();
}
