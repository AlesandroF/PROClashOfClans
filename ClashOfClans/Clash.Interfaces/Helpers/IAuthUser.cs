namespace Clash.Interfaces.Helpers
{
    public interface IAuthUser
    {
        int Id { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Role { get; set; }
    }
}