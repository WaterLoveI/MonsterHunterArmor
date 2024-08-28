using Terraria;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs
{
    public class BlueScroll : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
    }
}


