using System;
using System.Threading.Tasks;

using F10Y.T0006;


namespace F10Y.S0000
{
    [DemonstrationsMarker]
    public partial interface IProjectFileDemonstrations
    {
        public async Task Create_New_ProjectFile()
        {
            /// Inputs.
            var output_XmlFilePath = Instances.FilePaths.Output_ProjectFilePath;


            /// Run.
            var projectXElementActions = Instances.ProjectXElementActions;

            var element = Instances.XElementOperator.New(
                Instances.ProjectElementNames.Project,
                Instances.ProjectXElementActions.Set_Microsoft_NET_Sdk,
                Instances.XElementOperator.Get_Add_Child(
                    Instances.ProjectElementNames.PropertyGroup,
                    projectXElementActions.Set_Label_Main,
                    projectXElementActions.Add_OutputType_Exe,
                    projectXElementActions.Add_TargetFramework_net8_0,
                    projectXElementActions.Add_Warnings_Default,
                    projectXElementActions.Add_GenerateDocumentationFile
                    ),
                Instances.XElementOperator.Get_Add_Child(
                    Instances.ProjectElementNames.PropertyGroup,
                    projectXElementActions.Set_Label_Package,
                    projectXElementActions.Add_Version_Initial,
                    projectXElementActions.Add_Author_DCoats,
                    projectXElementActions.Add_Company_Functionairy,
                    projectXElementActions.Add_Copyright_Functionairy,
                    Instances.ProjectXElementOperator.Get_Add_Description(
                        Instances.Descriptions.Example_ForProject),
                    projectXElementActions.Add_PackageLicenseExpression_MIT,
                    projectXElementActions.Add_PackageRequireLicenseAcceptance,
                    projectXElementActions.Add_RepositoryUrl_F10Y_Z0010
                    ),
                Instances.XElementOperator.Get_Add_Child(
                    Instances.ProjectElementNames.ItemGroup,
                    projectXElementActions.Set_Label_ProjectReferences,
                    Instances.XElementOperator.Get_Add_Child(
                        Instances.ProjectElementNames.ProjectReference,
                        Instances.XElementOperator.Get_Set_Attribute_Value(
                            Instances.ProjectAttributeNames.Include,
                            @"..\F10Y.Z0010\F10Y.Z0010.csproj")
                        )
                    )
                );

            await Instances.ProjectXElementOperator.To_File(
                element,
                output_XmlFilePath,
                Instances.XmlWriterSettingsSet.Indent_AndOmitXmlDeclaration);

            Instances.NotepadPlusPlusOperator.Open(output_XmlFilePath);
        }

        public async Task Create_New_SimpleProjectFile()
        {
            /// Inputs.
            var output_ProjectFilePath =
                Instances.ProjectFilePaths.Output
                ;


            /// Run.
            var projectElement = Instances.ProjectXElementOperator.New_ProjectElement();

            Instances.ProjectXElementOperator.Set_SDK(
                projectElement,
                Instances.SdkNames.Microsoft_NET_Sdk);

            await Instances.ProjectXElementOperator.Save(
                projectElement,
                output_ProjectFilePath);

            Instances.NotepadPlusPlusOperator.Open(output_ProjectFilePath);
        }

        public async Task Create_New_EmptyProjectFile()
        {
            /// Inputs.
            var output_ProjectFilePath =
                Instances.ProjectFilePaths.Output
                ;


            /// Run.
            var projectElement = Instances.ProjectXElementOperator.New_ProjectElement();

            await Instances.ProjectXElementOperator.Save(
                projectElement,
                output_ProjectFilePath);

            Instances.NotepadPlusPlusOperator.Open(output_ProjectFilePath);
        }

        /// <summary>
        /// Round-trips the XML text contents of a project file.
        /// </summary>
        /// <returns></returns>
        public async Task RoundTrip_ProjectFileText()
        {
            /// Inputs.
            var projectFileXmlText =
                Instances.ProjectFileXmlTexts.Example_WithNonStandardFormatting
                ;

            var output_ProjectFilePath = Instances.FilePaths.Output_ProjectFilePath;
            var output_TextFilePath = Instances.FilePaths.Output_TextFilePath;


            /// Run.
            var projectElement = Instances.ProjectXElementOperator.Parse(projectFileXmlText);

            var projectFileXmlText_RoundTripped = Instances.ProjectXElementOperator.To_Text(projectElement);

            var xmlTexts_AreEqual = Instances.StringOperator.Are_Equal(
                projectFileXmlText,
                projectFileXmlText_RoundTripped);

            var lines_ForOutput = Instances.EnumerableOperator.From($"{xmlTexts_AreEqual}: XML texts are equal");

            await Instances.FileOperator.Write_Lines(
                output_TextFilePath,
                lines_ForOutput);

            await Instances.ProjectXElementOperator.Save(
                projectElement,
                output_ProjectFilePath);

            Instances.NotepadPlusPlusOperator.Open(
                output_ProjectFilePath,
                output_TextFilePath);
        }

        /// <summary>
        /// Round-trips a project file.
        /// </summary>
        public async Task RoundTrip_ProjectFile()
        {
            /// Inputs.
            var input_ProjectFilePath =
                //Instances.ProjectFilePaths.Example_Console
                Instances.ProjectFilePaths.Example_Library
                ;
            var output_ProjectFilePath =
                Instances.FilePaths.Output_ProjectFilePath
                ;

            var output_TextFilePath = Instances.FilePaths.Output_TextFilePath;


            /// Run.
            var projectElement = await Instances.ProjectXElementOperator.Load(input_ProjectFilePath);

            await Instances.ProjectXElementOperator.Save(
                projectElement,
                output_ProjectFilePath);

            var files_AreEqual = await Instances.FileOperator.Files_AreEqual_ByteLevel(
                input_ProjectFilePath,
                output_ProjectFilePath);

            var lines_ForOutput = Instances.EnumerableOperator.From($"{files_AreEqual}: files are equal");

            await Instances.FileOperator.Write_Lines(
                output_TextFilePath,
                lines_ForOutput);

            Instances.NotepadPlusPlusOperator.Open(
                input_ProjectFilePath,
                output_ProjectFilePath,
                output_TextFilePath);
        }
    }
}
