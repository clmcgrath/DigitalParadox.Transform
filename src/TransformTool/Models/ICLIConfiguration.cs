using System.Collections.Generic;
using DigitalParadox.Parsers.TemplateProcessor;

namespace TransformTool.Models
{
    public interface ICLIConfiguration
    {
        
        Dictionary<string, string> PluginDirectories { get; set; }
        ITemplateProcessorOptions ProcessorOptions { get; set; }
    }

    public class Configuration : ICLIConfiguration
    {
        public Configuration(ITemplateProcessorOptions processorOptions)
        {
            ProcessorOptions = processorOptions;
        }

        public Dictionary<string,string> PluginDirectories { get; set; }
      
        public ITemplateProcessorOptions ProcessorOptions { get; set; }
    }
}