using System.IO;
using DigitalParadox.Plugins;
using HandlebarsDotNet;
using TransformTool.Plugins.Helpers;

namespace TransformTool.Plugins
{
    public interface IHandlebarsHelper : IPlugin
    {
        string Name { get; set; }
        HelperType Type { get; set; }
        string Execute(TextWriter writer, HelperOptions options, dynamic data, params object[] args);
    }
}