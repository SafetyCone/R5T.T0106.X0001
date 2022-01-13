using System;
using System.Threading.Tasks;

using R5T.T0106;

using Instances = R5T.T0106.X0001.Instances;


namespace System
{
    public static class IProjectFileWithSolutionFileContextExtensions
    {
        public static async Task CreateHostStartupFile(this IProjectFileWithSolutionFileContext projectFileContext,
            Func<ProjectSubFilePathContext, Task> instancesFileContextAction = default)
        {
            await projectFileContext.InCodeDirectoryFilePathContext(
                Instances.CodeFileName.HostStartup(),
                instancesFileContextAction);
        }

        public static async Task CreateInstancesFile(this IProjectFileWithSolutionFileContext projectFileContext,
            Func<ProjectSubFilePathContext, Task> instancesFileContextAction = default)
        {
            await projectFileContext.InCodeDirectoryFilePathContext(
                Instances.CodeFileName.Instances(),
                instancesFileContextAction);
        }

        public static async Task CreateIServicActionExtensionsFile(this IProjectFileWithSolutionFileContext projectFileContext,
            Func<ProjectSubFilePathContext, Task> iServiceActionExtensionsFileContextAction = default)
        {
            await projectFileContext.InExtensionsDirectoryPathContext(
                async extensionsDirectoryPathContext =>
                {
                    await extensionsDirectoryPathContext.InProjectSubFilePathContex(
                        Instances.CodeFileName.IServiceActionExtensions(),
                        iServiceActionExtensionsFileContextAction);
                });
        }

        public static async Task CreateIServiceCollectionExtensionsFile(this IProjectFileWithSolutionFileContext projectFileContext,
            Func<ProjectSubFilePathContext, Task> iServiceCollectionExtensionsFileContextAction = default)
        {
            await projectFileContext.InExtensionsDirectoryPathContext(
                async extensionsDirectoryPathContext =>
                {
                    await extensionsDirectoryPathContext.InProjectSubFilePathContex(
                        Instances.CodeFileName.IServiceCollectionExtensions(),
                        iServiceCollectionExtensionsFileContextAction);
                });
        }

        public static async Task CreateProjectFile(this IProjectFileWithSolutionFileContext projectFileContext,
            Func<ProjectSubFilePathContext, Task> programFileContextAction = default)
        {
            await projectFileContext.InCodeDirectoryFilePathContext(
                Instances.CodeFileName.Program(),
                programFileContextAction);
        }

        public static async Task InBasesDirectoryPathContext(this IProjectFileWithSolutionFileContext projectFileContext,
            Func<ProjectSubDirectoryPathContext, Task> basesDirectoryContextAction = default)
        {
            await projectFileContext.InProjectSubDirectoryPathContext(
                Instances.ProjectPathsOperator.GetBasesDirectoryRelativePath(),
                basesDirectoryContextAction);
        }

        public static async Task InBasesExtensionsDirectoryPathContext(this IProjectFileWithSolutionFileContext projectFileContext,
            Func<ProjectSubDirectoryPathContext, Task> basesExtensionsDirectoryContextAction = default)
        {
            await projectFileContext.InProjectSubDirectoryPathContext(
                Instances.ProjectPathsOperator.GetBasesExtensionsDirectoryRelativePath(),
                basesExtensionsDirectoryContextAction);
        }

        public static async Task InExtensionsDirectoryPathContext(this IProjectFileWithSolutionFileContext projectFileContext,
            Func<ProjectSubDirectoryPathContext, Task> extensionsDirectoryContextAction = default)
        {
            await projectFileContext.InProjectSubDirectoryPathContext(
                Instances.ProjectPathsOperator.GetExtensionsDirectoryRelativePath(),
                extensionsDirectoryContextAction);
        }
    }
}
