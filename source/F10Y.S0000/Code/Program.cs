using System;
using System.Threading.Tasks;


namespace F10Y.S0000
{
    class Program
    {
        static async Task Main()
        {
            //await Program.Scripts_();
            //await Program.Scripts_Stopwatch();

            //await Program.Demonstrations_();
            //await Program.Demonstrations_Encoding();
            await Program.Demonstrations_ProjectFile();
            //await Program.Demonstrations_Stopwatch();
            //await Program.Demonstrations_Where();
            //await Program.Demonstrations_XElement();
            //await Program.Demonstrations_Xml();
        }

        #region Demonstrations

        static Task Demonstrations_()
        {
            throw new NotImplementedException();
        }

        static async Task Demonstrations_Encoding()
        {
            await EncodingDemonstrations.Instance.Write_WithBOM();
        }

        static async Task Demonstrations_ProjectFile()
        {
            await ProjectFileDemonstrations.Instance.Create_New_ProjectFile();
            //await ProjectFileDemonstrations.Instance.Create_New_SimpleProject();
            //await ProjectFileDemonstrations.Instance.Create_New_EmptyProject();
            //await ProjectFileDemonstrations.Instance.RoundTrip_ProjectFileText();
            //await ProjectFileDemonstrations.Instance.RoundTrip_ProjectFile();
        }

        static async Task Demonstrations_Stopwatch()
        {
            await StopwatchDemonstrations.Instance.Elapsed_OfUnstarted();
        }

        static async Task Demonstrations_Where()
        {
            await Instances.WhereDemonstrations.Where_Help();
            //await Instances.WhereDemonstrations.Where_IsWhere_WhereOperator();
            //await Instances.WhereDemonstrations.Where_IsWhere_CommandSyntax();
            //await Instances.WhereDemonstrations.Where_IsWhere_SimpleSyntax();
        }

        static async Task Demonstrations_XElement()
        {
            await XElementDemonstrations.Instance.Create_XElement_WithChildElement();
            //await XElementDemonstrations.Instance.Create_XElement_WithAttribute();
        }

        static async Task Demonstrations_Xml()
        {
            await XmlDemonstrations.Instance.RoundTrip_ExampleXmlText();
            //await XmlDemonstrations.Instance.RoundTrip_ExampleXmlFile();
        }

        #endregion

        #region Scripts

        static Task Scripts_()
        {
            throw new NotImplementedException();
        }

        static async Task Scripts_Stopwatch()
        {
            await StopwatchScripts.Instance.Display_StopwatchFrequencyAndResolution();
        }

        #endregion
    }
}