using Synapse;
using Synapse.Api;
using Synapse.Events;
using Synapse.Events.Classes;

namespace CuffedTK
{
    public class EventHandlers
    {
        public EventHandlers()
        {
            Events.PlayerDeathEvent += OnPlayerDeathEvent;
        }
        private void OnPlayerDeathEvent(PlayerDeathEvent ev)
        {
            string outputMessage = "\nWas cuffed: " + ev.Player.IsCuffed + "\nVictim ID: " + ev.Player.UserId + "\nVictim: " + ev.Player.NickName + "\nKiller ID: " + ev.Killer.UserId + "\nKiller: " + ev.Killer.NickName;
            RoleType victimRole = ev.Player.Role;
            RoleType killerRole = ev.Killer.Role;

            if (ev.Player.IsCuffed)
            {
                if ((victimRole == RoleType.ClassD && killerRole.IsScientistTeam()) || (victimRole == RoleType.Scientist && killerRole.IsDClassTeam()))
                {
                    ev.Player.SendConsoleMessage(outputMessage);
                    Log.Error(outputMessage);

                    if (MainPlugin.Configs.AutoJail)
                    {
                        ev.Killer.Jail.DoJail(ev.Player);
                    }
                }
            }
        }
    }
}
