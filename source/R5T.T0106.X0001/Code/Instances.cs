using System;

using R5T.T0037;
using R5T.T0040;
using R5T.T0113;


namespace R5T.T0106.X0001
{
    public static class Instances
    {
        public static ICodeFileName CodeFileName { get; } = T0037.CodeFileName.Instance;
        public static IProjectOperator ProjectOperator { get; } = T0113.ProjectOperator.Instance;
        public static IProjectPathsOperator ProjectPathsOperator { get; } = T0040.ProjectPathsOperator.Instance;
    }
}
