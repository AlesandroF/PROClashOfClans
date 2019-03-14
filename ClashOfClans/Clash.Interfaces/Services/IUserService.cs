using Clash.ValueObjectEntity.EntityManipulation;
using System.Collections.Generic;

namespace Clash.Interfaces.Services
{
    public interface IUserService
    {
        void InsertUser(VOUser user);
        IEnumerable<VOUser> GetAllUser();
        void DeleteUser(int id);
    }
}