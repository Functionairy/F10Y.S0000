using System;


namespace F10Y.S0000
{
    public class XmlAttributeNames : IXmlAttributeNames
    {
        #region Infrastructure

        public static IXmlAttributeNames Instance { get; } = new XmlAttributeNames();


        private XmlAttributeNames()
        {
        }

        #endregion
    }
}
