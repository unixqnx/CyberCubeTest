namespace DotNetCoreConsole.Dota2RatingObtaining
{
    public static class SteamHelper
    {
        #region Lockers

        private static object GetSteam32IdFromSteam64IdLocker = new object();

        #endregion

        public static int GetSteam32IdFromSteam64Id(long steam64Id)
        {
            lock (GetSteam32IdFromSteam64IdLocker)
            {
                int steam32ID;
                unchecked
                {
                    steam32ID = (int)steam64Id;
                }
                return steam32ID;
            }
        }
    }
}
