using Clash.Domain.Entities.Global;
using Clash.Interfaces.Global;

namespace Clash.Domain.Entities.API
{
    public class IconUrls : BaseEntity, IEntity<IconUrls>
    {
        public string Small { get; private set; }
        public string Tiny { get; private set; }
        public string Medium { get; private set; }

        public IconUrls() { }

        public IconUrls(string small, string tiny, string medium)
        {
            Small = small;
            Tiny = tiny;
            Medium = medium;
        }
    }
}