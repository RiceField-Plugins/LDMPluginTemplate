using Rocket.API.Collections;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using UnityEngine;
using Logger = Rocket.Core.Logging.Logger;

namespace LDMPluginTemplate
{
    public class Plugin : RocketPlugin<Configuration>
    {
        private static int Major = 1;
        private static int Minor = 0;
        private static int Patch = 0;
        
        public static Plugin Inst;
        public static Configuration Conf;
        public static Color MsgColor;

        protected override void Load()
        {
            Inst = this;
            Conf = Configuration.Instance;
            if (Conf.Enabled)
            {
                MsgColor = UnturnedChat.GetColorFromName(Conf.MessageColor, Color.green);
                
                // Subscribe event...
            }
            else
                Logger.LogWarning($"[{Name}] Plugin: DISABLED");

            Logger.LogWarning($"[{Name}] Plugin loaded successfully!");
            Logger.LogWarning($"[{Name}] {Name} v{Major}.{Minor}.{Patch}");
        }
        protected override void Unload()
        {
            if (Conf.Enabled)
            {
                // Unsubscribe event...
            }
            
            Conf = null;
            Inst = null;

            Logger.LogWarning($"[{Name}] Plugin unloaded successfully!");
        }
        public override TranslationList DefaultTranslations => new TranslationList
        {
            {"example_translation1", "Example Translation 1"},
        };
    }
}