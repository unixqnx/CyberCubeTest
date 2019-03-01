using RestSharp;
using System.Threading.Tasks;
using DotNetCoreConsole.Dota2RatingObtaining.Models;

namespace DotNetCoreConsole.Dota2RatingObtaining
{
    public class OpenDotaApi
    {
        public Player GetPlayer(long steam64Id)
        {
            return GetPlayerAsync(steam64Id).Result;
        }

        public async Task<Player> GetPlayerAsync(long steam64Id)
        {
            var steam32Id = SteamHelper.GetSteam32IdFromSteam64Id(steam64Id);
            var client = new RestClient($"https://api.opendota.com/api/players/{steam32Id}");
            return await client.GetAsync<Player>(new RestRequest());
        }
    }
}
