using Terraria;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class SpiritBirdPrism : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
    }
}
