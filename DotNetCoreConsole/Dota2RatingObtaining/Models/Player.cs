using RestSharp.Deserializers;

namespace DotNetCoreConsole.Dota2RatingObtaining.Models
{
    public class Player
    {
        [DeserializeAs(Name = "tracked_until")]
        public string TrackedUntil { get; set; }

        [DeserializeAs(Name = "solo_competitive_rank")]
        public string SoloCompetitiveRank { get; set; }

        [DeserializeAs(Name = "competitive_rank")]
        public string CompetitiveRank { get; set; }

        [DeserializeAs(Name = "rank_tier")]
        public int? RankTier { get; set; }

        [DeserializeAs(Name = "profile")]
        public Profile Profile { get; set; }

        [DeserializeAs(Name = "mmr_estimate")]
        public MmrEstimate MmrEstimate { get; set; }
    }
}
