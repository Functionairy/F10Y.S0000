using System;
using System.Threading.Tasks;

using F10Y.T0006;
using F10Y.T0011;


namespace F10Y.S0000
{
    [DemonstrationsMarker]
    public partial interface IStopwatchDemonstrations
    {
        /// <summary>
        /// Demonstrates that you <em>can</em> get the elapsed time of an unstarted stopwatch without an exception being thrown, and that time is 00:00:00.
        /// </summary>
        [InstanceIdentity("E6C5BAA9-F325-4CB2-9FF2-8532BB55924A")]
        public async Task Elapsed_OfUnstarted()
        {
            /// Inputs.
            var output_TextFilePath =
                Instances.FilePaths.Output_TextFilePath
                ;


            /// Run.
            // Get an unstarted stopwatch.
            var stopwatch = Instances.StopwatchOperator.New_Stopwatch();

            var elapsed = Instances.StopwatchOperator.Get_Elapsed(stopwatch);

            var lines_ForOutput = Instances.EnumerableOperator.From($"{elapsed}: elapsed time");

            await Instances.FileOperator.Write_Lines(
                output_TextFilePath,
                lines_ForOutput);

            Instances.NotepadPlusPlusOperator.Open(output_TextFilePath);
        }
    }
}
