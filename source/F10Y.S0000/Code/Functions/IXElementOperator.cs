using System;
using System.Xml.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.S0000
{
    [FunctionsMarker]
    public partial interface IXElementOperator :
        L0000.IXElementOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IXElementOperator _L0000 => L0000.XElementOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        
    }
}
