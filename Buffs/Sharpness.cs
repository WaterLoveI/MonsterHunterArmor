using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs
{
    public class Sharpness : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Terraria.Player player, ref int buffIndex)
        {
            MHPlayerArmorSkill modPlayer = player.GetModPlayer<MHPlayerArmorSkill>();
            modPlayer.Sharpness = true;
        }
    }
}


