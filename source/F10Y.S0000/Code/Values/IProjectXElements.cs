using System;
using System.Xml.Linq;

using F10Y.T0003;


namespace F10Y.S0000
{
    [ValuesMarker]
    public partial interface IProjectXElements
    {
        public XElement Empty => Instances.ProjectXElementOperator.New_ProjectElement();
    }
}
