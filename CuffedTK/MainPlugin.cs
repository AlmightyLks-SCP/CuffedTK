using Synapse.Api.Plugin;

namespace CuffedTK
{
    [PluginDetails(Author = "AlmightyLks",
        Description = "A plugin for handling Cuffed Teamkilling",
        Name = "CuffedTK",
        SynapseMajor = 1,
        SynapseMinor = 2,
        SynapsePatch = 1,
        Version = "1.0")]
    public class MainPlugin : Plugin
    {
        public static PluginConfigs Configs { get; set; }
        private EventHandlers EventHandlers { get; set; }

        public override void OnEnable()
        {
            Configs = new PluginConfigs();
            EventHandlers = new EventHandlers();
        }
    }
}
