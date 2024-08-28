using Terraria.ModLoader;

namespace MHArmorSkills
{
    public class MHArmorSkills : Mod
    {

        internal static MHArmorSkills Instance;
        public static ModKeybind ScrollSwap { get; private set; }
        public override void Load()
        {
            ScrollSwap = KeybindLoader.RegisterKeybind(this, "Scroll Swap", "G");
            Instance = this;
            MHLists.LoadLists();
        }
        public override void Unload()
        {
            Instance = null;
            MHLists.UnloadLists();
            ScrollSwap = null;
            base.Unload();
        }
    }
}