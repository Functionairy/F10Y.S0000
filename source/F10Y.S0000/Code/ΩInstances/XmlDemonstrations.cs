using System;


namespace F10Y.S0000
{
    public class XmlDemonstrations : IXmlDemonstrations
    {
        #region Infrastructure

        public static IXmlDemonstrations Instance { get; } = new XmlDemonstrations();


        private XmlDemonstrations()
        {
        }

        #endregion
    }
}
