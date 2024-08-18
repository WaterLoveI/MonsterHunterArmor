using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace MHArmorSkills.Config
{
    public class MHAconfigs : ModConfig
    {
        // just copied from example mod
        
        public override ConfigScope Mode => ConfigScope.ClientSide;


        [Header("On.Enter.Message")] // Headers are like titles in a config. You only need to declare a header on the item it should appear over, not every item in the category. 
        [Label("Enable")] // A label is the text displayed next to the option. This should usually be a short description of what it does. By default all ModConfig fields and properties have an automatic label translation key, but modders can specify a specific translation key.
        [Tooltip("$Enable for the on enter world message")] // A tooltip is a description showed when you hover your mouse over the option. It can be used as a more in-depth explanation of the option. Like with Label, a specific key can be provided.
        [DefaultValue(true)] // This sets the configs default value.
        [ReloadRequired] // Marking it with [ReloadRequired] makes tModLoader force a mod reload if the option is changed. It should be used for things like item toggles, which only take effect during mod loading
        public bool OnEnterMessage; 
    }
}
