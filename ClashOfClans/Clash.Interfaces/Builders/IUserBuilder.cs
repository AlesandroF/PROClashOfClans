using Clash.ValueObjectEntity.EntityManipulation;

namespace Clash.Interfaces.Builders
{
    public interface IUserBuilder<T>
    {
        T Build();

        IUserBuilder<T> From(VOUser user);
        IUserBuilder<T> WithUserName(string username);
        IUserBuilder<T> WithPassword(string password);
        IUserBuilder<T> WithRole(string role);
    }
}