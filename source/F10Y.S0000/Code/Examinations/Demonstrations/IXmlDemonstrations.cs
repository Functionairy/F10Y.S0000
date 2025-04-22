using System;
using System.Threading.Tasks;
using System.Xml;

using F10Y.T0006;


namespace F10Y.S0000
{
    [DemonstrationsMarker]
    public partial interface IXmlDemonstrations
    {
        public async Task RoundTrip_ExampleXmlText()
        {
            var xmlWriterSettings =
                //Instances.XmlWriterSettingsSet.OmitXmlDeclaration_Synchronous
                Instances.XmlWriterSettingsSet.OmitXmlDeclaration_Asynchronous
                ;

            /// Inputs
            var xmlText =
                Instances.XmlTexts.Example_02 // Non-standard formatting.
                ;

            var output_TextFilePath = Instances.FilePaths.Output_TextFilePath;
            var output_XmlFilePath = Instances.FilePaths.Output_XmlFilePath;


            /// Run.
            var element = Instances.XElementOperator.Parse(xmlText);

            var xmlText_RoundTripped = Instances.XElementOperator.To_Text(element);

            var xmlTexts_AreEqual = Instances.StringOperator.Are_Equal(
                xmlText,
                xmlText_RoundTripped);

            var lines_ForOutput = Instances.EnumerableOperator.From($"{xmlTexts_AreEqual}: texts are equal");

            await Instances.FileOperator.Write_Lines(
                output_TextFilePath,
                lines_ForOutput);

            //Instances.XElementOperator.Save_Synchronous(
            //    element,
            //    output_XmlFilePath,
            //    xmlWriterSettings);

            // Also write out the XML of the element.
            await Instances.XElementOperator.Save(
                element,
                output_XmlFilePath,
                xmlWriterSettings);

            Instances.NotepadPlusPlusOperator.Open(
                output_XmlFilePath,
                output_TextFilePath);
        }

        public async Task RoundTrip_ExampleXmlFile()
        {
            /// Inputs.


            /// Run.
            var loadOptions =
                Instances.LoadOptionsSet.PreserveWhitespace
                ;
            var xmlWriterSettings =
                Instances.XmlWriterSettingsSet.OmitXmlDeclaration_Synchronous
                ;

            await Instances.Operator.RoundTrip_ExampleXmlFile(
                xmlFilePath =>
                {
                    var output = Instances.XElementOperator.Load_Synchronous(
                        xmlFilePath,
                        loadOptions);

                    return Task.FromResult(output);
                },
                (xElement, xmlFilePath) =>
                {
                    using var xmlWriter = XmlWriter.Create(
                        xmlFilePath,
                        xmlWriterSettings);

                    xElement.Save(xmlWriter);

                    return Task.CompletedTask;
                });
        }
    }
}
