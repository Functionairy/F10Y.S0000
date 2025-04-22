using System;


namespace F10Y.S0000
{
    public class ProjectXElements : IProjectXElements
    {
        #region Infrastructure

        public static IProjectXElements Instance { get; } = new ProjectXElements();


        private ProjectXElements()
        {
        }

        #endregion
    }
}
