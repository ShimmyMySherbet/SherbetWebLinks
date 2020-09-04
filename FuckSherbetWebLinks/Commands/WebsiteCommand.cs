using System.Collections.Generic;
using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;

namespace SherbetWebLinks.Commands
{
    public class WebsiteCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "Website";

        public string Help => "Opens the server's website.";

        public string Syntax => "Website";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>() { "SherbetWebLinks.Website" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            if (!string.IsNullOrEmpty(SherbetWebLinks.Config.DiscordInvite))
            {
                UnturnedPlayer UPlayer = (UnturnedPlayer)caller;
                UPlayer.Player.sendBrowserRequest("WebLink_Open_Website".Translate(), SherbetWebLinks.Config.WebsiteURL);
            }
            else
            {
                UnturnedChat.Say(caller, "WebLink_NotSetup_Website".Translate());
            }
        }
    }
}