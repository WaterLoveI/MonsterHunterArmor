using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using MHArmorSkills.MHPlayer;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class AffinitySliding : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Terraria.Player player, ref int buffIndex)
        {

        }
    }
}


