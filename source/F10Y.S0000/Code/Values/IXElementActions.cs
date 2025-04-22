using System;
using System.Xml.Linq;

using F10Y.T0003;


namespace F10Y.S0000
{
    [ValuesMarker]
    public partial interface IXElementActions
    {
        /// <inheritdoc cref="L0004.IProjectXElementActions.Set_Microsoft_NET_Sdk"/>
        public Action<XElement> Set_Microsoft_NET_Sdk => Instances.ProjectXElementActions.Set_Microsoft_NET_Sdk;
    }
}
