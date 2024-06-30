using MHArmorSkills.Global;
using Terraria.ModLoader;

namespace MHArmorSkills
{
    public class MHArmorSkills : Mod
    {

        internal static MHArmorSkills Instance;
        public override void Load()
        {
            Instance = this;

            MHLists.LoadLists();
        }
        public override void Unload()
        {
            Instance = null;

            MHLists.UnloadLists();
            base.Unload();
        }
        
    }
}