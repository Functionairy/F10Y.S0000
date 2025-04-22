using System;


namespace F10Y.S0000
{
    public class StopwatchScripts : IStopwatchScripts
    {
        #region Infrastructure

        public static IStopwatchScripts Instance { get; } = new StopwatchScripts();


        private StopwatchScripts()
        {
        }

        #endregion
    }
}
