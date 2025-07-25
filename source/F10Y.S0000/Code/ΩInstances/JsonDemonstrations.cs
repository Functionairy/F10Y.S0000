using System;


namespace F10Y.S0000
{
    public class JsonDemonstrations : IJsonDemonstrations
    {
        #region Infrastructure

        public static IJsonDemonstrations Instance { get; } = new JsonDemonstrations();


        private JsonDemonstrations()
        {
        }

        #endregion
    }
}
