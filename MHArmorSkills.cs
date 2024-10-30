using MHArmorSkills.Items.Accessories.Decorations;
using Terraria.ModLoader;

namespace MHArmorSkills
{
    public class MHArmorSkills : Mod
    {

        internal static MHArmorSkills Instance;
        public static ModKeybind ScrollSwap { get; private set; }
        public static ModKeybind GuardButton { get; private set; }
        public override void Load()
        {
            ScrollSwap = KeybindLoader.RegisterKeybind(this, "Scroll Swap", "G");
            GuardButton = KeybindLoader.RegisterKeybind(this, "Guard", "F");
            Instance = this;
            MHLists.LoadLists();
            TooltipChanges.EditTooltips();
        }
        public override void Unload()
        {
            Instance = null;
            MHLists.UnloadLists();
            ScrollSwap = null;
            GuardButton = null;
            base.Unload();
            TooltipChanges.ResetTooltips();
        }
    }
}