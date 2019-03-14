using Clash.Interfaces.DTOs;
using Clash.Interfaces.Helpers;
using Clash.ValueObjectEntity.EntityManipulation;

namespace Clash.Interfaces.Services
{
    public interface IAuthenticationService
    {
        (string token, int userId) GenerateToken(IAuthUser authUser);
        IAuthUserDTO Login(IAuthUser authUser);
        bool ValidateUser(IAuthUser authUser);
        VOUser GetCurrentUser(int id);
    }
}