using Rocket.API;

namespace SherbetWebLinks.Models
{
    public class WeblinksConfig : IRocketPluginConfiguration
    {
        public string DiscordInvite;
        public string WebsiteURL;
        public string ApplyStaffURL;

        public void LoadDefaults()
        {
            DiscordInvite = "https://discord.com/invite/Kcx2dvE?__HEY!_Change_Me!";
            WebsiteURL = "https://YourWebsite.com/";
            ApplyStaffURL = "https://YourWebsite.com/ApplyStaff";
        }
    }
}