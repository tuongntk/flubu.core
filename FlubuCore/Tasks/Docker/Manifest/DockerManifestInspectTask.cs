
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Manifest
{
     public partial class DockerManifestInspectTask : ExternalProcessTaskBase<int, DockerManifestInspectTask>
     {
        private string _manifest_list;
private string _manifest;

        
        public DockerManifestInspectTask(string manifest_list,  string manifest)
        {
            ExecutablePath = "docker";
            WithArguments("manifest inspect");
_manifest_list = manifest_list;
_manifest = manifest;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// allow communication with an insecure registry
        /// </summary>
        public DockerManifestInspectTask Insecure()
        {
            WithArguments("insecure");
            return this;
        }

        /// <summary>
        /// Output additional info including layers and platform
        /// </summary>
        public DockerManifestInspectTask Verbose()
        {
            WithArguments("verbose");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_manifest_list);
 WithArguments(_manifest);

            return base.DoExecute(context);
        }

     }
}
