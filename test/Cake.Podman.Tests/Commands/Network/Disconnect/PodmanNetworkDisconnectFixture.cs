using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cake.Core;
using Cake.Core.Configuration;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Podman.Aliases;
using Cake.Podman.Commands.Network.Disconnect;
using Cake.Testing.Fixtures;

namespace Cake.Podman.Tests.Commands.Network.Disconnect
{
    public class PodmanNetworkDisconnectFixture : ToolFixture<PodmanNetworkDisconnectOptions>, ICakeContext
    {
        public PodmanNetworkDisconnectFixture() : base ("podman") {}

        public string? Network { get; set; }

        public string? Container { get; set; }

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
            this.PodmanNetworkDisconnect(Settings, Network!, Container!);
        }
    }
}