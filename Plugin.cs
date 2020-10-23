using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;
using n0tFlix.Channel.Pornhub.Configuration;
using System;

namespace n0tFlix.Channel.Pornhub
{
    public class Plugin : BasePlugin<PluginConfiguration>
    {
        /// <summary>
        /// The name of our plugin
        /// </summary>
        public override string Name => "Pornhub";

        /// <summary>
        /// Description of the plugin
        /// </summary>
        public override string Description => "Watch pornhub all day long";

        public override Guid Id => Guid.Parse("159e6d66-f87b-4d32-963c-882c29b24308");

        /// <summary>
        /// Gets the plugin instance.
        /// </summary>
        public static Plugin Instance { get; private set; }

        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
    : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }
    }
}