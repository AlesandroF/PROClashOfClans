using Clash.DataBase.Command.Base;
using Clash.Domain.Entities;
using Clash.Interfaces.Repositories;

namespace Clash.DataBase.Command.CommandUser
{
    public class CommandDeleteUser : BaseCommand
    {
        private readonly User User;
        private readonly IUserRepository<User> _userRepository;

        public CommandDeleteUser(User user, IUserRepository<User> userRepository)
        {
            User = user;
            _userRepository = userRepository;
        }

        protected override bool PreConditional()
        {
            if (User != null)
                return true;

            return false;
        }

        protected override void Semantic()
        {
            _userRepository.Delete(User);
        }
    }
}