using System;


namespace F10Y.S0000
{
    public class XmlNodeNames : IXmlNodeNames
    {
        #region Infrastructure

        public static IXmlNodeNames Instance { get; } = new XmlNodeNames();


        private XmlNodeNames()
        {
        }

        #endregion
    }
}
