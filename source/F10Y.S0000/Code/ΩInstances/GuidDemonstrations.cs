using System;


namespace F10Y.S0000
{
    public class GuidDemonstrations : IGuidDemonstrations
    {
        #region Infrastructure

        public static IGuidDemonstrations Instance { get; } = new GuidDemonstrations();


        private GuidDemonstrations()
        {
        }

        #endregion
    }
}
