using System;
using System.IO;
using DigitalParadox.Logging;
using HandlebarsDotNet;
using TransformTool.Models;
using TransformTool.Utilities;
using Unity;
using Unity.Extension;

namespace TransformTool.Config
{
    public class PluginConfiguration : UnityContainerExtension
    {
        public string WorkingDirectory => Environment.CurrentDirectory;
        public string AppDirectory => AppDomain.CurrentDomain.BaseDirectory;

        public ILog Log => Container.Resolve<ILog>();

        private string ResolvePathTemplate(string template, dynamic data)
        {
            var tpl = Handlebars.Compile(template);
            var result = tpl(data);
            return result;
        }

        protected override void Initialize()
        {

            string out_dir;
            var helpersDirectories = (Container.Resolve<Configuration>().PluginDirectories.TryGetValue("helpers", out out_dir)
                ? out_dir
                : @".\Plugins\Helpers").Split('|',StringSplitOptions.RemoveEmptyEntries);

            foreach (string dir in helpersDirectories)
            {
 
                var path = ResolvePathTemplate(dir, new {AppDirectory, WorkingDirectory});
                var di = new DirectoryInfo(path);

                if (!di.Exists)
                {
                    Log.WriteVerbose($"Plugin Directory {di.FullName} does not exist, skipping...");
                    continue;
                }
                

            }
        }
    }

    public class ConfigurationSetup : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<Configuration>();
            Container.RegisterType<ConfigurationTools>();
            Container.RegisterInstance(Container.Resolve<ConfigurationTools>().LoadAppConfig());
            Container.RegisterInstance(Container.Resolve<Configuration>()?.ProcessorOptions);
        }
    }
}
