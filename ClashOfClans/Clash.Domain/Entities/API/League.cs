using Clash.Domain.Entities.Global;
using Clash.Interfaces.Global;

namespace Clash.Domain.Entities.API
{
    public class League : BaseEntity, IEntity<League>
    {
        public string Name { get; private set; }

        public virtual IconUrls IconUrls { get; private set; }

        public League() { }

        public League(string name, IconUrls iconUrls)
        {
            Name = name;
            IconUrls = iconUrls;
        }
    }
}