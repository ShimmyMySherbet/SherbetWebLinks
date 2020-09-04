using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API.Collections;
using Rocket.Core.Plugins;
using SherbetWebLinks.Models;

namespace SherbetWebLinks
{
    public class SherbetWebLinks : RocketPlugin<WeblinksConfig>
    {
        public static SherbetWebLinks Instance;
        public static WeblinksConfig Config;
        public override void LoadPlugin()
        {
            base.LoadPlugin();
            Instance = this;
            Config = Configuration.Instance;
        }
        public override TranslationList DefaultTranslations => new TranslationList() {
            { "WebLink_Open_Discord", "Heres our Discord!"},
            { "WebLink_Open_Website", "Heres our Website!"},
            { "WebLink_Open_ApplyStaff", "Apply for staff here!"},
            { "WebLink_NotSetup_Discord", "There is no Discord invite set!"},
            { "WebLink_NotSetup_Website", "There is no Website URL set!"},
            { "WebLink_NotSetup_ApplyStaff", "There is no applications URL set!"}
        };
    }
}
