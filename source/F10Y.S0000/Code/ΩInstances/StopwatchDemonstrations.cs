using System;


namespace F10Y.S0000
{
    public class StopwatchDemonstrations : IStopwatchDemonstrations
    {
        #region Infrastructure

        public static IStopwatchDemonstrations Instance { get; } = new StopwatchDemonstrations();


        private StopwatchDemonstrations()
        {
        }

        #endregion
    }
}
