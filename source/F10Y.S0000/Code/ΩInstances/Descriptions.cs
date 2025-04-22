using System;


namespace F10Y.S0000
{
    public class Descriptions : IDescriptions
    {
        #region Infrastructure

        public static IDescriptions Instance { get; } = new Descriptions();


        private Descriptions()
        {
        }

        #endregion
    }
}
