using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cake.Core;
using Cake.Core.Configuration;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Podman.Aliases;
using Cake.Podman.Commands.Container.Run;
using Cake.Testing.Fixtures;

namespace Cake.Podman.Tests.Commands.Container.Run
{
    public class PodmanContainerRunFixture : ToolFixture<PodmanContainerRunOptions>, ICakeContext
    {
        public PodmanContainerRunFixture() : base("podman") { }

        public string? Image { get; set; }

        public string? Command { get; set; }

        public ICakeLog Log => Log;

        public ICakeArguments Arguments => throw new NotImplementedException();

        public IRegistry Registry => Registry;

        public ICakeDataResolver Data => throw new NotImplementedException();

        IFileSystem ICakeContext.FileSystem => FileSystem;

        ICakeEnvironment ICakeContext.Environment => Environment;

        IProcessRunner ICakeContext.ProcessRunner => ProcessRunner;

        ICakeConfiguration ICakeContext.Configuration => throw new NotImplementedException();

        protected override void RunTool()
        {
            this.PodmanContainerRun(Settings, Image!, Command!);
        }
    }
}