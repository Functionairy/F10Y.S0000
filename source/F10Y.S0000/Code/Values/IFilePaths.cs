using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.S0000
{
    [ValuesMarker]
    public partial interface IFilePaths :
        L0004.IFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0004.IFilePaths _L0004 => L0004.FilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>Files\Example.xml</value></para>
        /// </summary>
        public string Example_XmlFilePath_ExecutableDirectoryRelative => @"Files\Example.xml";

        /// <inheritdoc cref="Example_XmlFilePath_ExecutableDirectoryRelative"/>
        public string Example_XmlFilePath => Instances.ExecutablePathOperator.Get_Path_FromExecutableDirectoryRelativePath(
            this.Example_XmlFilePath_ExecutableDirectoryRelative);
    }
}
