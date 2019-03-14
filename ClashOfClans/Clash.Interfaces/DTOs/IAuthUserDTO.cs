namespace Clash.Interfaces.DTOs
{
    public interface IAuthUserDTO
    {
        int UserId { get; set; }
        string Token { get; set; }
    }
}