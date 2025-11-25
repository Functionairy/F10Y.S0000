using System;


namespace F10Y.S0000
{
    public class VersionDemonstrations : IVersionDemonstrations
    {
        #region Infrastructure

        public static IVersionDemonstrations Instance { get; } = new VersionDemonstrations();


        private VersionDemonstrations()
        {
        }

        #endregion
    }
}
