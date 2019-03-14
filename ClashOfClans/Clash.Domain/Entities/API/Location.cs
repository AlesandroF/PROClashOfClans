using Clash.Domain.Entities.Global;
using Clash.Interfaces.Global;

namespace Clash.Domain.Entities.API
{
    public class Location : BaseEntity, IEntity<Location>
    {
        public string Name { get; private set; }
        public bool IsCountry { get; private set; }
        public string CountryCode { get; private set; }

        public Location() { }

        public Location(string name, bool isCountry, string countryCode)
        {
            Name = name;
            IsCountry = isCountry;
            CountryCode = countryCode;
        }
    }
}