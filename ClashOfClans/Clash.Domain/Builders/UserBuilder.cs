using Clash.Domain.Entities;
using Clash.Interfaces.Builders;
using Clash.ValueObjectEntity.EntityManipulation;

namespace Clash.Domain.Builders
{
    public class UserBuilder : IUserBuilder<User>
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }

        public User Build()
        {
            return new User()
            {
                UserName = UserName,
                Password = Password,
                Role = Role
            };
        }

        public IUserBuilder<User> From(VOUser user)
        {
            UserName = user.UserName;
            Password = user.Password;
            Role = user.Role;

            return this;
        }

        public IUserBuilder<User> WithUserName(string username)
        {
            UserName = username;
            return this;
        }

        public IUserBuilder<User> WithPassword(string password)
        {
            Password = password;
            return this;
        }

        public IUserBuilder<User> WithRole(string role)
        {
            Role = role;
            return this;
        }
    }
}