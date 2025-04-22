using System;
using System.Linq;
using System.Threading.Tasks;

using F10Y.T0005;
using F10Y.T0011;


namespace F10Y.S0000
{
    [ScriptsMarker]
    public partial interface IStopwatchScripts
    {
        [InstanceIdentity("79262918-1F6B-43C8-89C3-0C95DDCF2DF2")]
        public async Task Display_StopwatchFrequencyAndResolution()
        {
            /// Inputs.
            var output_TextFilePath =
                Instances.FilePaths.Output_TextFilePath
                ;


            /// Run.
            var frequency = Instances.Values.Stopwatch_Frequency;
            var is_HighResolution = Instances.Values.Stopwatch_Is_HighResolution;

            var nanoseconds_PerTick = 1_000_000_000 / frequency;

            var lines_ForOutput = Instances.EnumerableOperator.From($"{frequency}: stopwatch frequency (ticks/s), or {nanoseconds_PerTick} nanoseconds-per-tick")
                .Append($"{is_HighResolution}: stopwatch is high resolution")
                ;

            await Instances.FileOperator.Write_Lines(
                output_TextFilePath,
                lines_ForOutput);

            Instances.NotepadPlusPlusOperator.Open(output_TextFilePath);
        }
    }
}
