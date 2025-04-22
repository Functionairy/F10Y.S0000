using System;


namespace F10Y.S0000
{
    public class XElementActions : IXElementActions
    {
        #region Infrastructure

        public static IXElementActions Instance { get; } = new XElementActions();


        private XElementActions()
        {
        }

        #endregion
    }
}
