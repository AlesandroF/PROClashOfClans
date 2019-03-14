using Clash.Domain.Entities.Global;
using Clash.Interfaces.Global;
using System.Collections.Generic;

namespace Clash.Domain.Entities.API
{
    public class Clan : BaseEntity, IEntity<Clan>
    {
        public string Tag { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Description { get; private set; }
        public int ClanLevel { get; private set; }
        public long ClanPoint { get; private set; }
        public long ClanVersusPoints { get; private set; }
        public int RequiredTrophies { get; private set; }
        public string WarFrequency { get; private set; }
        public int WarWinStreak { get; private set; }
        public int WarWins { get; private set; }
        public bool IsWarLogPublic { get; private set; }
        public int Members { get; private set; }

        public virtual BadgeUrls BadgeUrls { get; private set; }
        public virtual Location Location { get; private set; }
        public virtual ICollection<MemberList> MemberList { get; private set; }

        public Clan() { }

        public Clan(string tag, string name, string type, string description, Location location, BadgeUrls badgeUrls, int clanLevel, long clanPoint, long clanVersusPoints, int requiredTrophies, string warFrequency, int warWinStreak, int warWins, bool isWarLogPublic, int members, List<MemberList> memberList)
        {
            Tag = tag;
            Name = name;
            Type = type;
            Description = description;
            Location = location;
            BadgeUrls = badgeUrls;
            ClanLevel = clanLevel;
            ClanPoint = clanPoint;
            ClanVersusPoints = clanVersusPoints;
            RequiredTrophies = requiredTrophies;
            WarFrequency = warFrequency;
            WarWinStreak = warWinStreak;
            WarWins = warWins;
            IsWarLogPublic = isWarLogPublic;
            Members = members;
            MemberList = memberList;
        }
    }
}