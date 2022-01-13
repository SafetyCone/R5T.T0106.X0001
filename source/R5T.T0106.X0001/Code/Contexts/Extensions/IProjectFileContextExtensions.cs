using System;
using System.Threading.Tasks;

using R5T.T0106;

using Instances = R5T.T0106.X0001.Instances;


namespace System
{
    public static class IProjectFileContextExtensions
    {
        public static void DeleteInitialClass1File(this IProjectFileContext projectFileContext)
        {
            Instances.ProjectOperator.DeleteInitialClass1File(projectFileContext);
        }
    }
}
