using System.Collections.Generic;
using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;

namespace SherbetWebLinks.Commands
{
    public class DiscordCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "Discord";

        public string Help => "Opens the server's discord.";

        public string Syntax => "Discord";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>() { "SherbetWebLinks.Discord" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            if (!string.IsNullOrEmpty(SherbetWebLinks.Config.DiscordInvite))
            {
                UnturnedPlayer UPlayer = (UnturnedPlayer)caller;
                UPlayer.Player.sendBrowserRequest("WebLink_Open_Discord".Translate(), SherbetWebLinks.Config.DiscordInvite);
            }
            else
            {
                UnturnedChat.Say(caller, "WebLink_NotSetup_Discord".Translate());
            }
        }
    }
}