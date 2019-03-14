using Clash.DataBase.Command.CommandUser;
using Clash.Domain.Entities;
using Clash.Interfaces.Builders;
using Clash.Interfaces.Repositories;
using Clash.Interfaces.Services;
using Clash.ValueObjectEntity.EntityManipulation;
using System.Collections.Generic;
using System.Linq;

namespace Clash.Authentication.AuthService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository<User> _userRepository;
        private readonly IUserBuilder<User> _userBuilder;

        public UserService(IUserRepository<User> userRepository, IUserBuilder<User> userBuilder)
        {
            _userRepository = userRepository;
            _userBuilder = userBuilder;
        }

        public void InsertUser(VOUser user)
        {
            var insertUser = new CommandInsertUser(_userBuilder.From(user).Build(), _userRepository);
            insertUser.Execute();
        }

        public void DeleteUser(int id)
        {
            var deleteUser = new CommandDeleteUser(_userRepository.GetById(id), _userRepository);
            deleteUser.Execute();
        }

        public IEnumerable<VOUser> GetAllUser()
        {
            var usuariosDB = _userRepository.GetAll();
            var users = usuariosDB.Select(t => new VOUser(t.UserName, string.Empty, t.Id, t.Role));

            return users;
        }
    }
}