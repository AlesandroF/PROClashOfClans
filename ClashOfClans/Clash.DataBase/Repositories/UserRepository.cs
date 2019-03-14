using Clash.DataBase.Context;
using Clash.Domain.Entities;
using Clash.Interfaces.Helpers;
using Clash.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Linq;

namespace Clash.DataBase.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository<User>
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context) : base(context)
        {
            _context = context;
        }

        public User GetUserByNameAndPassword(IAuthUser user)
        {
            SqlParameter usernameParameter = new SqlParameter("@UserName", user.UserName);
            SqlParameter passwordParameter = new SqlParameter("@Password", user.Password);

            return _context.Users.FromSql($"SELECT * FROM dbo.Users WHERE UserName = @UserName AND Password = @Password", usernameParameter, passwordParameter).FirstOrDefault();
        }
    }
}