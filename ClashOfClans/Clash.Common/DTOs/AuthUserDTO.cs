using Clash.Interfaces.DTOs;

namespace Clash.Common.DTOs
{
    public class AuthUserDTO : IAuthUserDTO
    {
        public int UserId { get; set; }
        public string Token { get; set; }

        private AuthUserDTO(int userId, string token)
        {
            UserId = userId;
            Token = token;
        }

        public static IAuthUserDTO Create(int userId, string token)
        {
            return new AuthUserDTO(userId, token);
        }
    }
}