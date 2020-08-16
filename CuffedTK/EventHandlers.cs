using Synapse;
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
            if (ev.Player.Role == RoleType.ClassD && (ev.Killer.Role.ToString().ToLower().Contains("ntf") || ev.Killer.Role == RoleType.Scientist || ev.Killer.Role == RoleType.FacilityGuard) || ev.Player.Role == RoleType.Scientist && (ev.Killer.Role == RoleType.ChaosInsurgency || ev.Killer.Role == RoleType.ClassD))
            {
                if (ev.Player.IsCuffed)
                {
                    ev.Player.SendConsoleMessage("\nWas cuffed: " + ev.Player.IsCuffed + "\nVictim ID: " + ev.Player.UserId + "\nVictim: " + ev.Player.NickName + "\nKiller ID: " + ev.Killer.UserId + "\nKiller: " + ev.Killer.NickName);
                    Log.Error("\nWas cuffed: " + ev.Player.IsCuffed + "\nVictim ID: " + ev.Player.UserId + "\nVictim: " + ev.Player.NickName + "\nKiller ID: " + ev.Killer.UserId + "\nKiller: " + ev.Killer.NickName);
                    if (MainPlugin.AutoJail)
                        ev.Killer.Jail.DoJail(ev.Player);
                }
                else
                    ev.Player.SendConsoleMessage("\nWas cuffed: " + ev.Player.IsCuffed + "\nVictim ID: " + ev.Player.UserId + "\nVictim: " + ev.Player.NickName + "\nKiller ID: " + ev.Killer.UserId + "\nKiller: " + ev.Killer.NickName, "green");
            }
        }
    }
}