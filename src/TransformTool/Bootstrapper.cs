using CommonServiceLocator;
using DigitalParadox.Logging.Serilog;
using DigitalParadox.Parsers.Yaml;
using TransformTool.Config;
using Unity;
using Unity.ServiceLocation;
using Unity.Extension;

namespace TransformTool
{
    public class Bootstrapper : UnityContainer
    {
        public virtual void Setup()
        {
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(this));

            //external container setup 
            //this.AddNewExtension<SerilogPlugin>();
            //.AddExtension<UnityContainerExtension>();
            //.AddNewExtension<SerilogPlugin>()
            //.AddNewExtension<YamlUnityExtension>()
            //.AddNewExtension<CommandLineParserPlugin>()
            //.AddNewExtension<ConfigurationSetup>()
            //.AddNewExtension<PluginConfiguration>();

        }
    }
}