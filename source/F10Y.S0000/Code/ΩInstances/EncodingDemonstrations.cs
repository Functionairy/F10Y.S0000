using System;


namespace F10Y.S0000
{
    public class EncodingDemonstrations : IEncodingDemonstrations
    {
        #region Infrastructure

        public static IEncodingDemonstrations Instance { get; } = new EncodingDemonstrations();


        private EncodingDemonstrations()
        {
        }

        #endregion
    }
}
