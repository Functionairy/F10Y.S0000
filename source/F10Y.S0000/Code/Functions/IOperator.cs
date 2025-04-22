using System;
using System.Threading.Tasks;
using System.Xml.Linq;

using F10Y.T0002;


namespace F10Y.S0000
{
    [FunctionsMarker]
    public partial interface IOperator
    {
        public async Task RoundTrip_ExampleXmlFile(
            Func<string, Task<XElement>> load_Function,
            Func<XElement, string, Task> save_Function)
        {
            /// Inputs
            var output_TextFilePath = Instances.FilePaths.Output_TextFilePath;
            var output_XmlFilePath = Instances.FilePaths.Output_XmlFilePath;

            var example_XmlFilePath = Instances.FilePaths.Example_XmlFilePath;


            /// Run.
            var xElement = await load_Function(example_XmlFilePath);

            await save_Function(
                xElement,
                output_XmlFilePath);

            var files_AreEqual = await Instances.FileOperator.Files_AreEqual_ByteLevel(
                example_XmlFilePath,
                output_XmlFilePath);

            var lines_ForOutput = Instances.EnumerableOperator.From($"{files_AreEqual}: files are equal");

            await Instances.FileOperator.Write_Lines(
                output_TextFilePath,
                lines_ForOutput);

            Instances.NotepadPlusPlusOperator.Open(
                output_XmlFilePath,
                output_TextFilePath);
        }
    }
}
