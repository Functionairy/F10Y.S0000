using System;


namespace F10Y.S0000
{
    public class XElementDemonstrations : IXElementDemonstrations
    {
        #region Infrastructure

        public static IXElementDemonstrations Instance { get; } = new XElementDemonstrations();


        private XElementDemonstrations()
        {
        }

        #endregion
    }
}
