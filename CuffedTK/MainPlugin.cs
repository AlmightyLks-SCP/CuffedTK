using Synapse.Api.Plugin;

namespace CuffedTK
{
    [PluginDetails(Author = "AlmightyLks",
        Description = "A plugin for handling Cuffed-Scientist Teamkilling",
        Name = "CuffedTK",
        SynapseMajor = 1,
        SynapseMinor = 2,
        SynapsePatch = 1,
        Version = "1.0.0")]
    public class MainPlugin : Plugin
    {
        public static bool AutoJail { get; set; }
        private EventHandlers EventHandlers { get; set; }

        public override void OnEnable()
        {
            EventHandlers = new EventHandlers();
        }
    }
}
