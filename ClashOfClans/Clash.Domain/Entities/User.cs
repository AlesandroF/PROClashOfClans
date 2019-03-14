using Clash.Domain.Entities.Global;
using Clash.Interfaces.Global;

namespace Clash.Domain.Entities
{
    public class User : BaseEntity, IEntity<User>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}