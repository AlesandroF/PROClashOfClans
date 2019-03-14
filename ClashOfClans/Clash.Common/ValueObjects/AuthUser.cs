using Clash.Interfaces.Helpers;

namespace Clash.Common.ValueObjects
{
    public class AuthUser : IAuthUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public AuthUser() { }

        private AuthUser(int id, string userName, string password, string role)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Role = role;
        }

        public static AuthUser Create(int id, string userName, string password, string role)
        {
            return new AuthUser(id, userName, password, role);
        }
    }
}