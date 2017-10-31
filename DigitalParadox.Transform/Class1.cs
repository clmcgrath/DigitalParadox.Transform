using Nuke.Core;
using System;
using System.IO;

namespace DigitalParadox.SlowCheetah
{
    public class TransformJDT : NukeBuild {
        
    }
    public class TransformXDT : NukeBuild
    {
        public FileInfo TransformPath { get; set; }
        public FileInfo TransformTargetPath { get; set; }

        protected string Description { get; set; } = "Apply XDT Transform to target file"

        Target Transform_XML => _ => _
            .Requires(() => TransformPath)
            .Requires(() => TransformTargetPath )
            .Description("Apply XDT Transform to target file")
            .Executes(() => {
                XDTTransform 
                    
            });
    }


}
