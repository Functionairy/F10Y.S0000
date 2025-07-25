using System;

using F10Y.T0006;
using F10Y.T0011;


namespace F10Y.S0000
{
    [DemonstrationsMarker]
    public partial interface IJsonDemonstrations :
        L0024.Q000.IJsonDemonstrations,
        L0060.Q000.IJsonDemonstrations
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// netstandard2.1 System.Text.Json package-based.
        /// </summary>
        [Ignore]
        public L0024.Q000.IJsonDemonstrations _F10Y_L0024_Q000 => L0024.Q000.JsonDemonstrations.Instance;

        /// <summary>
        /// net6.0 built-in functionality-based.
        /// </summary>
        [Ignore]
        public L0060.Q000.IJsonDemonstrations _F10Y_L0060_Q000 => L0060.Q000.JsonDemonstrations.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
