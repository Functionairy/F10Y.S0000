using System;


namespace F10Y.S0000
{
    public class XmlElementNames : IXmlElementNames
    {
        #region Infrastructure

        public static IXmlElementNames Instance { get; } = new XmlElementNames();


        private XmlElementNames()
        {
        }

        #endregion
    }
}
