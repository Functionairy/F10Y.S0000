using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.S0000
{
    [ValuesMarker]
    public partial interface IXmlAttributeNames
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0006.Z000.IProjectAttributeNames _ProjectAttributeNames => L0006.Z000.ProjectAttributeNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="L0006.Z000.IProjectAttributeNames.Label"/>
        public string Label => _ProjectAttributeNames.Label;

        /// <inheritdoc cref="L0006.Z000.IProjectAttributeNames.SDK"/>
        public string SDK => _ProjectAttributeNames.SDK;
    }
}
