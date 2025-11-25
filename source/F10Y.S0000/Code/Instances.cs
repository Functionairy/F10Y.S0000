using System;


namespace F10Y.S0000
{
    public static class Instances
    {
        public static L0006.IAuthorsOperator AuthorsOperator => L0006.AuthorsOperator.Instance;
        public static L0004.IAuthorSets AuthorSets => L0004.AuthorSets.Instance;
        public static L0006.IBooleanOperator BooleanOperator => L0006.BooleanOperator.Instance;
        public static L0004.ICompanyNames CompanyNames => L0004.CompanyNames.Instance;
        public static L0004.ICopyrightOperator CopyrightOperator => L0004.CopyrightOperator.Instance;
        public static L0000.IDateTimeOperator DateTimeOperator => L0000.DateTimeOperator.Instance;
        public static IDescriptions Descriptions => S0000.Descriptions.Instance;
        public static L0000.IEncodings Encodings => L0000.Encodings.Instance;
        public static Q0000.IEnumerableDemonstrations EnumerableDemonstrations => Q0000.EnumerableDemonstrations.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static L0000.IExecutablePathOperator ExecutablePathOperator => L0000.ExecutablePathOperator.Instance;
        public static L0000.IFileOperator FileOperator => L0000.FileOperator.Instance;
        public static IFilePaths FilePaths => S0000.FilePaths.Instance;
        public static L0000.Q000.IGuidDemonstrations GuidDemonstrations => S0000.GuidDemonstrations.Instance;
        public static IJsonDemonstrations JsonDemonstrations => S0000.JsonDemonstrations.Instance;
        public static L0004.ILoadOptionsSet LoadOptionsSet => L0004.LoadOptionsSet.Instance;
        public static L0019.INotepadPlusPlusOperator NotepadPlusPlusOperator => L0019.NotepadPlusPlusOperator.Instance;
        public static L0000.INowOperator NowOperator => L0000.NowOperator.Instance;
        public static IOperator Operator => S0000.Operator.Instance;
        public static Z0002.IOutputTypes OutputTypes => Z0002.OutputTypes.Instance;
        public static Z0002.IPackageLicenseExpressions PackageLicenseExpressions => Z0002.PackageLicenseExpressions.Instance;
        public static L0006.Z000.IProjectAttributeNames ProjectAttributeNames => L0006.Z000.ProjectAttributeNames.Instance;
        public static L0006.Z000.IProjectElementNames ProjectElementNames => L0006.Z000.ProjectElementNames.Instance;
        public static IProjectFilePaths ProjectFilePaths => S0000.ProjectFilePaths.Instance;
        public static Z0010.IProjectFileXmlTexts ProjectFileXmlTexts => Z0010.ProjectFileXmlTexts.Instance;
        public static L0004.IProjectGroupElementLabels ProjectGroupElementLabels => L0004.ProjectGroupElementLabels.Instance;
        public static L0004.IProjectXElementActions ProjectXElementActions => L0004.ProjectXElementActions.Instance;
        public static L0004.IProjectXElementOperator ProjectXElementOperator => L0004.ProjectXElementOperator.Instance;
        public static L0004.IRepositoryUrls RepositoryUrls => L0004.RepositoryUrls.Instance;
        public static Z0002.ISdkNames SdkNames => Z0002.SdkNames.Instance;
        public static L0000.IStopwatchOperator StopwatchOperator => L0000.StopwatchOperator.Instance;
        public static L0000.IStreamWriterOperator StreamWriterOperator => L0000.StreamWriterOperator.Instance;
        public static L0000.IStringOperator StringOperator => L0000.StringOperator.Instance;
        public static L0000.IStrings Strings => L0000.Strings.Instance;
        public static Z0002.ITargetFrameworkMonikers TargetFrameworkMonikers => Z0002.TargetFrameworkMonikers.Instance;
        public static L0000.IValues Values => L0000.Values.Instance;
        public static L0000.Q000.IVersionDemonstrations VersionDemonstrations => S0000.VersionDemonstrations.Instance;
        public static L0006.IVersionOperator VersionOperator => L0006.VersionOperator.Instance;
        public static L0000.IVersions Versions => L0000.Versions.Instance;
        public static Z0002.IWarnings Warnings => Z0002.Warnings.Instance;
        public static L0004.IWarningSets WarningSets => L0004.WarningSets.Instance;
        public static L0006.IWarningsOperator WarningsOperator => L0006.WarningsOperator.Instance;
        public static L0021.Q000.IWhereDemonstrations WhereDemonstrations => L0021.Q000.WhereDemonstrations.Instance;
        public static L0000.IXAttributeOperator XAttributeOperator => L0000.XAttributeOperator.Instance;
        public static IXElementOperator XElementOperator => S0000.XElementOperator.Instance;
        public static IXElementActions XElementActions => S0000.XElementActions.Instance;
        public static IXmlAttributeNames XmlAttributeNames => S0000.XmlAttributeNames.Instance;
        public static IXmlElementNames XmlElementNames => S0000.XmlElementNames.Instance;
        public static Z0000.IXmlTexts XmlTexts => Z0000.XmlTexts.Instance;
        public static L0000.IXmlWriterSettingsSet XmlWriterSettingsSet => L0000.XmlWriterSettingsSet.Instance;
    }
}