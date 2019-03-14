using Clash.Domain.Entities.Global;
using Clash.Interfaces.Global;

namespace Clash.Domain.Entities.API
{
    public class MemberList : BaseEntity, IEntity<MemberList>
    {
        public string Tag { get; private set; }
        public string Name { get; private set; }
        public string Role { get; private set; }
        public int ExpLevel { get; private set; }
        public int Trophies { get; private set; }
        public int VersusTrophies { get; private set; }
        public int ClanRank { get; private set; }
        public int PreviousClanRank { get; private set; }
        public int Donation { get; private set; }
        public int DonationsReceived { get; private set; }

        public virtual League League { get; private set; }

        public MemberList() { }

        public MemberList(string tag, string name, string role, int expLevel, League league, int trophies, int versusTrophies, int clanRank, int previousClanRank, int donation, int donationsReceived)
        {
            Tag = tag;
            Name = name;
            Role = role;
            ExpLevel = expLevel;
            League = league;
            Trophies = trophies;
            VersusTrophies = versusTrophies;
            ClanRank = clanRank;
            PreviousClanRank = previousClanRank;
            Donation = donation;
            DonationsReceived = donationsReceived;
        }
    }
}