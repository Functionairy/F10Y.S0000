using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.S0000
{
    [ValuesMarker]
    public partial interface IXmlElementNames
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0006.Z000.IProjectElementNames _ProjectElementNames => L0006.Z000.ProjectElementNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="L0006.Z000.IProjectElementNames.Project"/>
        public string Project => _ProjectElementNames.Project;

        /// <inheritdoc cref="L0006.Z000.IProjectElementNames.PropertyGroup"/>
        public string PropertyGroup => _ProjectElementNames.PropertyGroup;
    }
}
