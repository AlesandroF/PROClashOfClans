using Clash.Domain.Entities.Global;
using Clash.Interfaces.Global;

namespace Clash.Domain.Entities.API
{
    public class BadgeUrls : BaseEntity, IEntity<BadgeUrls>
    {
        public string Small { get; private set; }
        public string Large { get; private set; }
        public string Medium { get; private set; }

        public BadgeUrls() { }

        public BadgeUrls(string small, string large, string medium)
        {
            Small = small;
            Large = large;
            Medium = medium;
        }
    }
}