using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.S0000
{
    [ValuesMarker]
    public partial interface IProjectFilePaths :
        Z0010.IProjectFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z0010.IProjectFilePaths _Z0010 => Z0010.ProjectFilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles

        /// <inheritdoc cref="L0004.IFilePaths.Output_ProjectFilePath"/>
        public string Output => Instances.FilePaths.Output_ProjectFilePath;
    }
}
