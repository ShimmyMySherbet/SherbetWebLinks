using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            DiscordInvite = "YourDiscordInvite";
            WebsiteURL = "https://YourWebsite.com/";
            ApplyStaffURL = "https://YourWebsite.com/ApplyStaff";

        }
    }
}
