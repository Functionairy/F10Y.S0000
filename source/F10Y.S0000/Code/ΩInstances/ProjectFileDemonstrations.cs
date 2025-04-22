using System;


namespace F10Y.S0000
{
    public class ProjectFileDemonstrations : IProjectFileDemonstrations
    {
        #region Infrastructure

        public static IProjectFileDemonstrations Instance { get; } = new ProjectFileDemonstrations();


        private ProjectFileDemonstrations()
        {
        }

        #endregion
    }
}
