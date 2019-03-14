using Clash.Interfaces.Helpers;

namespace Clash.Interfaces.Repositories
{
    public interface IUserRepository<T> : IBaseRepository<T>
    {
        T GetUserByNameAndPassword(IAuthUser user);
    }
}