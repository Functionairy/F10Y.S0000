using System;
using System.Threading.Tasks;

using F10Y.T0006;


namespace F10Y.S0000
{
    [DemonstrationsMarker]
    public partial interface IXElementDemonstrations
    {
        public async Task Create_XElement_WithChildElement()
        {
            /// Inputs.
            var output_XmlFilePath = Instances.FilePaths.Output_XmlFilePath;


            /// Run.
            var element = Instances.XElementOperator.New(
                Instances.XmlElementNames.Project,
                Instances.XElementActions.Set_Microsoft_NET_Sdk,
                Instances.XElementOperator.Get_Add_Child(
                    Instances.XmlElementNames.PropertyGroup,
                    Instances.XElementOperator.Get_Set_Attribute_Value(
                        Instances.XmlAttributeNames.Label,
                        Instances.ProjectGroupElementLabels.Main)
                    )
                );

            await Instances.XElementOperator.To_File(
                element,
                output_XmlFilePath,
                Instances.XmlWriterSettingsSet.Indent_AndOmitXmlDeclaration);

            Instances.NotepadPlusPlusOperator.Open(output_XmlFilePath);
        }

        public async Task Create_XElement_WithAttribute()
        {
            /// Inputs.
            var output_XmlFilePath = Instances.FilePaths.Output_XmlFilePath;


            /// Run.
            //var element = Instances.XElementOperator.New(
            //    Instances.XmlElementNames.Project);

            ////var attribute = Instances.XElementOperator.Acquire_Attribute(
            ////    element,
            ////    Instances.XmlAttributeNames.SDK);

            ////Instances.XAttributeOperator.Set_Value(
            ////    attribute,
            ////    Instances.SdkNames.Microsoft_NET_Sdk);

            //Instances.XElementOperator.Set_Attribute_Value(
            //    element,
            //    Instances.XmlAttributeNames.SDK,
            //    Instances.SdkNames.Microsoft_NET_Sdk);

            //var element = Instances.XElementOperator.New(
            //    Instances.XmlElementNames.Project,
            //    Instances.XElementOperator.Get_Set_Attribute_Value(
            //        Instances.XmlAttributeNames.SDK,
            //        Instances.SdkNames.Microsoft_NET_Sdk)
            //    );

            var element = Instances.XElementOperator.New(
                Instances.XmlElementNames.Project,
                Instances.XElementActions.Set_Microsoft_NET_Sdk
                );

            await Instances.XElementOperator.To_File_WithoutXmlDeclaration(
                element,
                output_XmlFilePath);

            Instances.NotepadPlusPlusOperator.Open(output_XmlFilePath);
        }
    }
}
