using Rocket.API.Collections;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using UnityEngine;
using Logger = Rocket.Core.Logging.Logger;

namespace LDMPluginTemplate
{
    public class Plugin : RocketPlugin<Configuration>
    {
        public static Plugin Inst;
        public static Configuration Conf;
        public static Color MsgColor;

        protected override void Load()
        {
            Inst = this;
            Conf = Configuration.Instance;
            MsgColor = UnturnedChat.GetColorFromName(Conf.MessageColor, Color.green);
            if (!Configuration.Instance.Enabled)
            {
                Logger.LogWarning($"[{Name}] Plugin: DISABLED");
                Unload();
                return;
            }

            Logger.LogWarning($"[{Name}] Plugin loaded successfully!");
        }
        protected override void Unload()
        {
            Inst = null;
            Conf = null;

            Logger.LogWarning($"[{Name}] Plugin unloaded successfully!");
        }
        public override TranslationList DefaultTranslations => new TranslationList
        {
            {"example_translation1", "[LDMPluginTemplate] Example Translation 1"},
        };
        
        
    }
}