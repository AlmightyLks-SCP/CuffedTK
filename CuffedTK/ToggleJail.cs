using System;
using CommandSystem;

namespace CuffedTK
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class ToggleJail : ICommand
    {
        public string Command { get; } = "autojail";
        public string[] Aliases { get; } = { "aj" };
        public string Description { get; } = "Toggles Auto Jailing On Teamkill";
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            MainPlugin.AutoJail = !MainPlugin.AutoJail;
            response = "Auto Jail: " + MainPlugin.AutoJail;

            return true;
        }
    }
}
