using System.Collections.Generic;
using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;

namespace SherbetWebLinks.Commands
{
    public class ApplyStaffCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "ApplyStaff";

        public string Help => "Opens the server's staff applications page.";

        public string Syntax => "ApplyStaff";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>() { "SherbetWebLinks.ApplyStaff" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            if (!string.IsNullOrEmpty(SherbetWebLinks.Config.DiscordInvite))
            {
                UnturnedPlayer UPlayer = (UnturnedPlayer)caller;
                UPlayer.Player.sendBrowserRequest("WebLink_Open_ApplyStaff".Translate(), SherbetWebLinks.Config.ApplyStaffURL);
            }
            else
            {
                UnturnedChat.Say(caller, "WebLink_NotSetup_ApplyStaff".Translate());
            }
        }
    }
}