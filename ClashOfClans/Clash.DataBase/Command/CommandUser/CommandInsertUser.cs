using Clash.DataBase.Command.Base;
using Clash.Domain.Entities;
using Clash.Interfaces.Repositories;

namespace Clash.DataBase.Command.CommandUser
{
    public class CommandInsertUser : BaseCommand
    {
        private readonly User User;
        private readonly IUserRepository<User> _userRepository;

        public CommandInsertUser(User user, IUserRepository<User> userRepository)
        {
            User = user;
            _userRepository = userRepository;
        }

        protected override bool PreConditional()
        {
            if (!string.IsNullOrEmpty(User.UserName) && !string.IsNullOrEmpty(User.Password))
            {
                return true;
            }
            return false;
        }

        protected override void Semantic()
        {
            _userRepository.Insert(User);
        }
    }
}