using System;

using R5T.T0040;

using Instances = R5T.T0106.X0001.Instances;


namespace System
{
    public static class IProjectPathsOperatorExtensions
    {
        public static string GetHostStartupFileRelativePath(this IProjectPathsOperator _)
        {
            var output = _.GetCodeDirectoryFileRelativePath(
                Instances.CodeFileName.HostStartup());

            return output;
        }
    }
}
