using RestSharp.Deserializers;

namespace DotNetCoreConsole.Dota2RatingObtaining.Models
{
    public class Profile
    {
        [DeserializeAs(Name = "account_id")]
        public int? AccountId { get; set; }

        [DeserializeAs(Name = "personaname")]
        public string PersonaName { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "cheese")]
        public int? Cheese { get; set; }

        [DeserializeAs(Name = "steamid")]
        public string SteamId { get; set; }

        [DeserializeAs(Name = "avatar")]
        public string Avatar { get; set; }

        [DeserializeAs(Name = "avatarmedium")]
        public string AvatarMedium { get; set; }

        [DeserializeAs(Name = "avatarfull")]
        public string AvatarFull { get; set; }

        [DeserializeAs(Name = "profileurl")]
        public string ProfileUrl { get; set; }

        [DeserializeAs(Name = "last_login")]
        public string LastLogin { get; set; }

        [DeserializeAs(Name = "loccountrycode")]
        public string LocCountryCode { get; set; }

        [DeserializeAs(Name = "is_contributor")]
        public bool? IsContributor { get; set; }
    }
}
