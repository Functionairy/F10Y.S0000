using System;
using System.Threading.Tasks;

using F10Y.T0006;


namespace F10Y.S0000
{
    [DemonstrationsMarker]
    public partial interface IEncodingDemonstrations
    {
        public async Task Write_WithBOM()
        {
            /// Inputs.
            var input_TextFilePath =
                @"C:\Code\DEV\Git\GitHub\Functionairy\F10Y.Z0010\source\F10Y.Z0010.Z000\Files\F10Y.Z0010.Z000\Example_Library.csproj"
                ;
            var output_TextFilePath =
                //Instances.FilePaths.Output_ProjectFilePath
                input_TextFilePath
                ;


            /// Run.
            var text = await Instances.FileOperator.Read_AllText(input_TextFilePath);

            using var writer = Instances.StreamWriterOperator.New(
                output_TextFilePath,
                Instances.Encodings.UTF8_WithBOM);

            await writer.WriteAsync(text);

            Instances.NotepadPlusPlusOperator.Open(
                input_TextFilePath,
                output_TextFilePath);
        }
    }
}
