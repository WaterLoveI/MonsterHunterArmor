using Terraria;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs
{
    public class ScrollChange : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
    }
}


