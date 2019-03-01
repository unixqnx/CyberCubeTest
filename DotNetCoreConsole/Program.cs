using System;
using System.Threading.Tasks;
using DotNetCoreConsole.Dota2RatingObtaining;
using RestSharp;
            using RestSharp.Authenticators;
using DotNetCoreConsole.Dota2RatingObtaining.Models;


namespace DotNetCoreConsole
{
    class Program
    {


        public static Player GetPlayer2(long user64Id)
        {
            int user32Id = GetSteam32IDFromSteam64ID(user64Id);
            Uri url = new Uri($"https://api.opendota.com/api/players/{user32Id}");
            var client = new RestClient(url);
            return client.Get<Player>(new RestRequest()).Data;
        }


        public static async Task<Player> GetPlayerAsync2(string userId32)
        {
            Uri url = new Uri($"https://api.opendota.com/api/players/{userId32}");
            var client = new RestClient(url);
            return await client.GetAsync<Player>(new RestRequest());
        }



        public static int GetSteam32IDFromSteam64ID(long steam64ID)
        {
            int steam32ID;
            unchecked
            {
                steam32ID = (int)steam64ID;
            }
            return steam32ID;
        }


        public static async Task Main(string[] args)
        {
            //var Steam64ID = 76561198244177142;
            //var d = GetPlayer2(76561198059574062);//99308334


            var openDotaApi = new OpenDotaApi();

            //b00m - Денис API = 3823, Dota2 = NO
            var result = openDotaApi.GetPlayer(long.Parse("76561198244177142"));
            var mmr = result.MmrEstimate.Estimate;

            //Я рюкзак. - чел у которого есть рейтинг API = 3492, Dota2 = 3560
            var result2 = openDotaApi.GetPlayer(long.Parse("76561198059574062"));
            var mmr2 = result2.MmrEstimate.Estimate;

            Console.WriteLine();







            #region RATING CALCULATION

            //var AElo = 100; 
            //var BElo = 100;
            //var AplayedGames = 10;
            //var BplayedGames = 10;


            
            //var newRatingAWIN = Elo.GetNewEloForA(AElo, BElo, AplayedGames, GameResult.WIN);
            //Console.WriteLine($"A win old={AElo}; new={newRatingAWIN}");

            //var newRatingBLOSE = Elo.GetNewEloForA(BElo, AElo, BplayedGames, GameResult.LOSE);
            //Console.WriteLine($"B lose old={AElo}; new={newRatingBLOSE}");


            //var newRatingADRAW = Elo.GetNewEloForA(AElo, BElo, AplayedGames, GameResult.DRAW);
            //Console.WriteLine($"B DRAW old={AElo}; new={newRatingADRAW}");

            //var newRatingBDRAW = Elo.GetNewEloForA(BElo, AElo, BplayedGames, GameResult.DRAW);
            //Console.WriteLine($"B DRAW old={AElo}; new={newRatingBDRAW}");

            #endregion


        }


        //static async Task Main(string[] args)
        //{
        //    await DisplayTempAsync();
        //}


        //static void Main(string[] args)
        //{
        //    var s =  GetPlayer("99308334");
        //}
    }
}
