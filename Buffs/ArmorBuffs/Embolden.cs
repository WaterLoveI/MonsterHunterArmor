using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Embolden : ModBuff
    {
        
        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
    }
}



