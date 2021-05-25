using Rocket.API;

namespace LDMPluginTemplate
{
    public class Configuration : IRocketPluginConfiguration
    {
        public bool Enabled;
        public string MessageColor;
        
        public void LoadDefaults()
        {
            Enabled = true;
            MessageColor = "green";
        }
    }
}